﻿using System;
using System.Collections.Generic;
using Interactables;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;
using Random = System.Random;

namespace FirstPerson
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(FirstPersonMovement))]
    [RequireComponent(typeof(FirstPersonAiming))]
    public class FirstPersonPlayer : MonoBehaviourPun, IPunObservable
    {
        [Header("Interact Parameters")] [SerializeField]
        private float interactRange = 10f;

        [SerializeField] private LayerMask interactMask;

        [Tooltip("The local player instance. Use this to know if the local player is represented in the Scene")]
        public static FirstPersonPlayer LocalPlayerInstance;

        public List<AudioClip> stepClips;

        #region Required Components
        
        [Header("Required components")]
        private FirstPersonAiming aim;
        private FirstPersonMovement mov;
        private PlayerInput input;
        private AudioSource _audioSource;

        #endregion
        
        
        [SerializeField] private GameObject capsuleModel;
        [SerializeField] private GameObject animatedModel;

        #region Player Stuff

        [Header("Tools")]
        [SerializeField] private List<Tool> tools;
        private Tool activeTool;
        private int equippedToolIndex;

        #endregion

        #region Carryable Stuff

        [Header("Carrying stuff")] 
        [SerializeField] private float pullForce;
        [SerializeField] private float launchForce = 100f;
        [SerializeField] private Transform carryingPoint;
        private bool isCarrying;
        private GameObject carryingObject;
        private Transform carryingTrans;
        private Rigidbody carryingRb;
        

        #endregion

        private PauseMenu _pauseMenu;
        
        private void Awake()
        {
            // #Important
            // used in GameManager.cs: we keep track of the localPlayer instance to prevent instantiation when levels are synchronized
            if (photonView.IsMine)
            {
                FirstPersonPlayer.LocalPlayerInstance = this;
            }
            // #Critical
            // we flag as don't destroy on load so that instance survives level synchronization, thus giving a seamless experience when levels load.
            DontDestroyOnLoad(this.gameObject);
        }

    
        /// <summary>
        /// Start will be called for each players instance (4 in total) when the GameManager spawns the players through
        /// PhotonNetwork. 
        /// </summary>
        void Start()
        {
            if(!PhotonNetwork.IsConnected)
                PhotonNetwork.OfflineMode = true;
            aim = GetComponent<FirstPersonAiming>();
            mov = GetComponent<FirstPersonMovement>();
            input = GetComponent<PlayerInput>();
            _audioSource = GetComponent<AudioSource>();

            gameObject.tag = "Player";
            
            Setup();
        }

        private void FixedUpdate()
        {
        }

        /// <summary>
        /// This is simply a wrapper for the Tool.UseTool method so we can tag it as a PunRPC.
        /// </summary>
        [PunRPC]
        public void UseTool(InputActionPhase phase)
        {
            //Debug.Log("RPC UseTool called", this);
            // Criar um ENUM que representa o Tipo de Input realizado
            // Investigar metodos de disntinção de Input
            activeTool.UseTool(phase);
        }

        [PunRPC]
        public void UseToolSecondary(InputActionPhase phase)
        {
            activeTool.UseToolSecondary(phase);
        }

        public void PlayeNextStepAudio()
        {
            int nextClip = new Random().Next(stepClips.Count);
            Play(stepClips[nextClip]);
        }

        public void Play(AudioClip clip)
        {
            _audioSource.PlayOneShot(clip);
        }

        #region Local VS Remote setup

        /// <summary>
        /// Setup players so there's no conflict between local and remote player
        /// </summary>
        void Setup()
        {
            if(GameManager.instance != null)
                _pauseMenu = GameManager.instance.CanvasSpawned.GetComponent<PauseMenu>();
            if (photonView.IsMine || !PhotonNetwork.IsConnected)
            {
                //Setup local player (change appearance and enable controls)
                input.enabled = true;
                SetupModel(true);
            }
            else
            {
                //Setup object as remote player (show the humanoid model and disable controls)
                input.enabled = false;
                aim.DisableCamera();
                SetupModel(false);
            }
        }

        void SetupModel(bool isLocal)
        {
            foreach (Tool tool in tools)
            {
                tool.GetComponentInChildren<MeshRenderer>().enabled = isLocal;
                GameObject o;
                (o = tool.gameObject).SetActive(false);
                o.layer = isLocal ? 11 : 12; // LocalTool : RemoteTool
                Utils.Utils.SetLayerToChildren(o, o.layer);
            }

            animatedModel.layer = isLocal ? 9 : 10; // LocalModel : RemoteModel
            Utils.Utils.SetLayerToChildren(animatedModel, animatedModel.layer);

            activeTool = tools[0];
            ChangeTool(0);
            
        }

        #endregion



        #region Handle Input
        
        public void OnMovement(InputAction.CallbackContext ctx)
        {
            Vector2 input = ctx.ReadValue<Vector2>();
            mov.ReceiveMovementInput(input.x, input.y);
        }
    
        public void OnJump(InputAction.CallbackContext ctx)
        {
            if(ctx.performed)
                mov.ReceiveJumpInput();
        }

        public void OnAim(InputAction.CallbackContext ctx)
        {
            Vector2 input = ctx.ReadValue<Vector2>();
            aim.ReceiveAimInput(input.x, input.y);
        }

        public void OnToolUse(InputAction.CallbackContext ctx)
        {
            if (isCarrying)
            {
                if (PhotonNetwork.OfflineMode)
                {
                    LaunchObject();
                }else
                    photonView.RPC("LaunchObject", RpcTarget.All);
            } else if (PhotonNetwork.OfflineMode) 
                activeTool.UseTool(ctx.phase);
            else
                photonView.RPC("UseTool", RpcTarget.All, ctx.phase);

        }

        public void OnToolUseSecondary(InputAction.CallbackContext ctx)
        {
            if(PhotonNetwork.OfflineMode)
                activeTool.UseToolSecondary(ctx.phase);
            else
                photonView.RPC("UseToolSecondary", RpcTarget.All, ctx.phase);
        }

        public void OnInteract(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                Transform camTransform = aim.camTransform;
                RaycastHit hit;
                Debug.DrawRay(camTransform.position, camTransform.forward, Color.red, 3f);
                
                if (isCarrying)
                {
                    if(PhotonNetwork.OfflineMode)
                       DropObject();
                    else
                        photonView.RPC("DropObject", RpcTarget.All);
                }
                else if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, interactRange, interactMask))
                {
                    if (hit.collider.CompareTag("Interactable"))
                    {
                        
                         hit.collider.GetComponentInParent<Interactable>().Interact();
                        
                    }

                    if (hit.collider.CompareTag("Carryable"))
                    {
                        if(PhotonNetwork.OfflineMode)
                            CarryObject(hit.collider.gameObject);
                        else
                            photonView.RPC("CarryObjectFromView", RpcTarget.All, PhotonView.Get(hit.collider).ViewID);
                    }
                }
            }
        }

        public void OnMenu(InputAction.CallbackContext ctx)
        {
            if (ctx.started)
            {
                if (_pauseMenu == null)
                {
                    if (GameManager.instance != null)
                        _pauseMenu = PauseMenu.Instance;
                    Debug.LogError("COULDN'T FIND PAUSEMENU, WHERE IS IT?", this);
                }

                _pauseMenu.MenuTrigger();
            }
        }

        public void OnAnalytics(InputAction.CallbackContext ctx)
        {
            if (ctx.started)
            {
                if (_pauseMenu != null)
                {
                    _pauseMenu.ToggleAnalytics();
                }
                else
                {
                    Debug.LogError("COULDN'T FIND PAUSEMENU, WHERE IS IT?", this);
                }
            }
        }

        public void OnEquipFlashlight(InputAction.CallbackContext ctx)
        {
            if(PhotonNetwork.OfflineMode)
                ChangeTool(0);
            else
            {
                photonView.RPC("ChangeTool", RpcTarget.All, 0);
            }
        }

        public void OnEquipGravitygun(InputAction.CallbackContext ctx)
        {
            if(PhotonNetwork.OfflineMode)
                ChangeTool(1);
            else
            {
                photonView.RPC("ChangeTool", RpcTarget.All, 1);
            }
        }
        #endregion

        public void ChangePlayerActionMap(string actionMap)
        {
            input.SwitchCurrentActionMap(actionMap);
        }
        
        [PunRPC]
        private void ChangeTool(int toolIndex)
        {
            if(toolIndex >= tools.Count || toolIndex < 0)
            {
                Debug.LogError("Trying to list tools at an illegal position");
                return;
            }
            
            // Disable old tool
            activeTool.gameObject.SetActive(false);
            
            // Set new Tool
            equippedToolIndex = toolIndex;
            activeTool = tools[equippedToolIndex];
            
            // Enable new tool
            activeTool.gameObject.SetActive(true);
        }
        
        /// <summary>
        /// Shoots a Raycast forward to look for an Interactable
        /// </summary>
        [PunRPC]
        private void TryInteracting(GameObject interactable)
        {
            interactable.GetComponent<Interactable>().Interact();
        }

        [PunRPC]
        private void CarryObjectFromView(int viewId)
        {
            CarryObject(PhotonView.Find(viewId).gameObject);
        }
        
        private void CarryObject(GameObject carryAble)
        {
            isCarrying = true;
            carryingObject = carryAble;
            carryingRb = carryAble.GetComponent<Rigidbody>();
            carryingTrans = carryAble.transform;
            carryingTrans.parent = carryingPoint;
            carryingTrans.localPosition = Vector3.zero;
            carryingRb.isKinematic = true;
        }

        [PunRPC]
        private void DropObject()
        {
            isCarrying = false;
            carryingTrans.parent = null;
            carryingRb.isKinematic = false;
            carryingRb = null;
            carryingTrans = null;
            carryingObject = null;
        }

        [PunRPC]
        private void LaunchObject()
        {
            isCarrying = false;
            carryingTrans.parent = null;
            carryingRb.isKinematic = false;
            carryingRb.AddForce(aim.camTransform.forward*launchForce, ForceMode.Impulse);
            carryingRb = null;
            carryingTrans = null;
            carryingObject = null;
        }

        [PunRPC]
        private void TeleportPlayer(Vector3 position)
        {
            transform.position = position;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("MovingPlatform"))
            {
                transform.parent = other.transform;
            }
            else if (other.gameObject.CompareTag("Teleport"))
            {
                Teleport teleport = other.gameObject.GetComponent<Teleport>();
                if(PhotonNetwork.OfflineMode)
                    TeleportPlayer(teleport.MasterTeleportPoint.position);
                else if(photonView.IsMine)
                {
                    Vector3 teleportPosition = PhotonNetwork.IsMasterClient
                        ? teleport.MasterTeleportPoint.position
                        : teleport.ClientTeleportPoint.position;
                    photonView.RPC("TeleportPlayer", RpcTarget.All, teleportPosition);
                }

                if(teleport.bluePortal)
                    teleport.PlayPortalSound();
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("MovingPlatform"))
            {
                transform.parent = null;
            }
        }

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            if (stream.IsWriting)
            {
                // Transform sync
                stream.SendNext(transform.position);
                stream.SendNext(transform.rotation);
                
                // Rigidbody velocity
                if(mov.Rb != null)
                    stream.SendNext(mov.Rb.velocity);
                else
                {
                    stream.SendNext(Vector3.zero);
                }
                
                // Camera Transform sync
                stream.SendNext(aim.camTransform.position);
                stream.SendNext(aim.camTransform.rotation);
            }
            else
            {
                // Transform sync
                transform.position = (Vector3) stream.ReceiveNext();
                transform.rotation = (Quaternion) stream.ReceiveNext();
                
                // Rigidbody velocity
                Vector3 vel = (Vector3) stream.ReceiveNext();
                vel.y = 0;
                if(mov != null)
                    mov.SetAnimatorSpeed(vel);
                
                // Camera Transform sync
                aim.camTransform.position = (Vector3) stream.ReceiveNext();
                aim.camTransform.rotation = (Quaternion) stream.ReceiveNext();
            }
        }
    }
}
