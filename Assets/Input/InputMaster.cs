// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f295c62a-6b4b-4570-8d29-875598f29435"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3049149a-4519-4db0-8cf7-0f07940bf7ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a5f6c38c-4062-4035-8bd3-0b94c4da4b5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""06f4c5ef-5bc7-467c-ad5d-ec7747fd540e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseTool"",
                    ""type"": ""Button"",
                    ""id"": ""7171b0ae-ec56-495e-b359-26891136f38f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""UseToolSecondary"",
                    ""type"": ""Button"",
                    ""id"": ""300ddf04-b38e-417e-a946-8b0618ee6c96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""578753ef-c66c-4f63-a65e-6800305872de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""dfc9b81e-f954-4c67-bc7a-832584c56f01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Analitics"",
                    ""type"": ""Button"",
                    ""id"": ""371bf5c2-5504-4902-b29c-5b03a0ad091e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Equip Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""52bf8503-bc90-44b4-873e-0c387835c532"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Equip Gravity gun"",
                    ""type"": ""Button"",
                    ""id"": ""10b0a9e2-24bf-4ef2-a57c-058e50bf0dfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter Debug"",
                    ""type"": ""Button"",
                    ""id"": ""e432d3ba-98de-4a64-a034-0a5df3e4dccc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ce9571a-f547-46cd-8e2c-60f1e7f45ad4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a3f64f85-53c2-43b9-8e43-5c59dae033d3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a262d53f-7438-4607-b66b-ab02c5faff93"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d0ed76d9-64db-4b8b-81ab-599ae6f7a65e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f8409c3c-01ae-4a0f-b424-aaa9b9985634"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""75b84387-056a-4933-b16a-9c5b98cd3251"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c87a33b5-6642-46b5-9b5e-47a228819768"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bf9f2a8-faff-425f-adb6-fe7fc66b7402"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335f4d7f-39e6-4229-869e-34b7c56a6e82"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b6c8705-6128-4e9d-b902-92ae95664cd7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""674d9967-2d64-4dba-98ed-8bf62f566823"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""UseTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1b1cf4e-84bf-4dfb-92cb-b4f5336b6260"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UseTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""851c1e00-82d2-4831-afdb-9931e17e4849"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0083dfd0-43a1-40a0-bb21-d014403d3f99"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b95effd8-af65-4ede-b906-b1371c25db33"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b0c58a7-d452-4962-bbfc-e7b45b66e28e"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Analitics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c75d3c0-6206-44d6-b5e6-1e30e63266cc"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Equip Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""251c273d-baf3-47ae-84b6-441ef89ed390"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Equip Gravity gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""776d1b4f-62f4-49ac-9c88-77ad9689b825"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""UseToolSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5e8c83c-5a7d-4ff2-b6b0-fa2444086d49"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UseToolSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80a9f40f-d424-414a-b878-eeb7c03b3697"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Enter Debug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""b65da1f3-b68b-4c22-9fe0-2ad24eb4a738"",
            ""actions"": [
                {
                    ""name"": ""Analitics"",
                    ""type"": ""Button"",
                    ""id"": ""fba66de4-204f-432f-a61e-9ba00fc9ce5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""2a770155-a94f-4667-8a00-063a51057b62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f9201f2-cbf5-4415-b090-c8bf8fbddf7f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0531037c-356e-4568-8283-dbaad7885ee0"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a18cd606-be3e-4b9a-b14d-c47e090826ba"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Analitics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""88c5c450-6e21-4734-8db9-acd125376b35"",
            ""actions"": [
                {
                    ""name"": ""FastSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""b8271e45-a0e8-4487-b5da-0dd93c61760a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlowSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""fac177bb-a8cf-4fad-9edb-ec5e43a83b55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ascend"",
                    ""type"": ""Button"",
                    ""id"": ""eaaf01a6-61c8-4fbb-9315-01d5115ab8bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Descend"",
                    ""type"": ""Button"",
                    ""id"": ""a5451b5b-936b-45c3-901c-05007b58e42a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""aa352b17-0dbd-4599-b21f-06f8906805e3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c71e543d-a2af-44a6-b66f-de03e3dda556"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Leave Debug"",
                    ""type"": ""Button"",
                    ""id"": ""10d5d7df-54c6-4b40-833f-903aad8343c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0ac0a3b-439c-41b4-b813-4fec1fc6276f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""FastSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88a59195-92c9-4cf0-9b61-3c260342710e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SlowSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e598abc8-4230-495c-af92-59a93e797ca4"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63141169-31cc-4a12-b19c-c7669de7eda9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Descend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b6a6867-f1bf-4a10-9f7d-c8b87c282380"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d8deb56b-b340-489f-a8b1-3a697b07e579"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""faef0e85-32a4-48f4-9641-d7d90eb7292a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff9a6a76-4d6e-4242-8f4c-adad37d97214"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e039d8cb-3fbb-4ca5-83e5-bfeb97117e67"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5c3f18c2-cdc9-44cd-96ef-e566604d2b8a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""61f5d29a-da2d-43b6-b97d-fe9ab484c270"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Leave Debug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_UseTool = m_Player.FindAction("UseTool", throwIfNotFound: true);
        m_Player_UseToolSecondary = m_Player.FindAction("UseToolSecondary", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_Analitics = m_Player.FindAction("Analitics", throwIfNotFound: true);
        m_Player_EquipFlashlight = m_Player.FindAction("Equip Flashlight", throwIfNotFound: true);
        m_Player_EquipGravitygun = m_Player.FindAction("Equip Gravity gun", throwIfNotFound: true);
        m_Player_EnterDebug = m_Player.FindAction("Enter Debug", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Analitics = m_Menu.FindAction("Analitics", throwIfNotFound: true);
        m_Menu_Menu = m_Menu.FindAction("Menu", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_FastSpeed = m_Debug.FindAction("FastSpeed", throwIfNotFound: true);
        m_Debug_SlowSpeed = m_Debug.FindAction("SlowSpeed", throwIfNotFound: true);
        m_Debug_Ascend = m_Debug.FindAction("Ascend", throwIfNotFound: true);
        m_Debug_Descend = m_Debug.FindAction("Descend", throwIfNotFound: true);
        m_Debug_Aim = m_Debug.FindAction("Aim", throwIfNotFound: true);
        m_Debug_Movement = m_Debug.FindAction("Movement", throwIfNotFound: true);
        m_Debug_LeaveDebug = m_Debug.FindAction("Leave Debug", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_UseTool;
    private readonly InputAction m_Player_UseToolSecondary;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_Analitics;
    private readonly InputAction m_Player_EquipFlashlight;
    private readonly InputAction m_Player_EquipGravitygun;
    private readonly InputAction m_Player_EnterDebug;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @UseTool => m_Wrapper.m_Player_UseTool;
        public InputAction @UseToolSecondary => m_Wrapper.m_Player_UseToolSecondary;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @Analitics => m_Wrapper.m_Player_Analitics;
        public InputAction @EquipFlashlight => m_Wrapper.m_Player_EquipFlashlight;
        public InputAction @EquipGravitygun => m_Wrapper.m_Player_EquipGravitygun;
        public InputAction @EnterDebug => m_Wrapper.m_Player_EnterDebug;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @UseTool.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseTool;
                @UseTool.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseTool;
                @UseTool.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseTool;
                @UseToolSecondary.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseToolSecondary;
                @UseToolSecondary.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseToolSecondary;
                @UseToolSecondary.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseToolSecondary;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Analitics.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalitics;
                @Analitics.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalitics;
                @Analitics.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalitics;
                @EquipFlashlight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipFlashlight;
                @EquipFlashlight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipFlashlight;
                @EquipFlashlight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipFlashlight;
                @EquipGravitygun.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipGravitygun;
                @EquipGravitygun.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipGravitygun;
                @EquipGravitygun.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipGravitygun;
                @EnterDebug.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterDebug;
                @EnterDebug.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterDebug;
                @EnterDebug.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterDebug;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @UseTool.started += instance.OnUseTool;
                @UseTool.performed += instance.OnUseTool;
                @UseTool.canceled += instance.OnUseTool;
                @UseToolSecondary.started += instance.OnUseToolSecondary;
                @UseToolSecondary.performed += instance.OnUseToolSecondary;
                @UseToolSecondary.canceled += instance.OnUseToolSecondary;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Analitics.started += instance.OnAnalitics;
                @Analitics.performed += instance.OnAnalitics;
                @Analitics.canceled += instance.OnAnalitics;
                @EquipFlashlight.started += instance.OnEquipFlashlight;
                @EquipFlashlight.performed += instance.OnEquipFlashlight;
                @EquipFlashlight.canceled += instance.OnEquipFlashlight;
                @EquipGravitygun.started += instance.OnEquipGravitygun;
                @EquipGravitygun.performed += instance.OnEquipGravitygun;
                @EquipGravitygun.canceled += instance.OnEquipGravitygun;
                @EnterDebug.started += instance.OnEnterDebug;
                @EnterDebug.performed += instance.OnEnterDebug;
                @EnterDebug.canceled += instance.OnEnterDebug;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Analitics;
    private readonly InputAction m_Menu_Menu;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Analitics => m_Wrapper.m_Menu_Analitics;
        public InputAction @Menu => m_Wrapper.m_Menu_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Analitics.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnalitics;
                @Analitics.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnalitics;
                @Analitics.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnAnalitics;
                @Menu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Analitics.started += instance.OnAnalitics;
                @Analitics.performed += instance.OnAnalitics;
                @Analitics.canceled += instance.OnAnalitics;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_FastSpeed;
    private readonly InputAction m_Debug_SlowSpeed;
    private readonly InputAction m_Debug_Ascend;
    private readonly InputAction m_Debug_Descend;
    private readonly InputAction m_Debug_Aim;
    private readonly InputAction m_Debug_Movement;
    private readonly InputAction m_Debug_LeaveDebug;
    public struct DebugActions
    {
        private @InputMaster m_Wrapper;
        public DebugActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @FastSpeed => m_Wrapper.m_Debug_FastSpeed;
        public InputAction @SlowSpeed => m_Wrapper.m_Debug_SlowSpeed;
        public InputAction @Ascend => m_Wrapper.m_Debug_Ascend;
        public InputAction @Descend => m_Wrapper.m_Debug_Descend;
        public InputAction @Aim => m_Wrapper.m_Debug_Aim;
        public InputAction @Movement => m_Wrapper.m_Debug_Movement;
        public InputAction @LeaveDebug => m_Wrapper.m_Debug_LeaveDebug;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @FastSpeed.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnFastSpeed;
                @FastSpeed.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnFastSpeed;
                @FastSpeed.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnFastSpeed;
                @SlowSpeed.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnSlowSpeed;
                @SlowSpeed.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnSlowSpeed;
                @SlowSpeed.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnSlowSpeed;
                @Ascend.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnAscend;
                @Ascend.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnAscend;
                @Ascend.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnAscend;
                @Descend.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnDescend;
                @Descend.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnDescend;
                @Descend.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnDescend;
                @Aim.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnAim;
                @Movement.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnMovement;
                @LeaveDebug.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeaveDebug;
                @LeaveDebug.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeaveDebug;
                @LeaveDebug.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeaveDebug;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FastSpeed.started += instance.OnFastSpeed;
                @FastSpeed.performed += instance.OnFastSpeed;
                @FastSpeed.canceled += instance.OnFastSpeed;
                @SlowSpeed.started += instance.OnSlowSpeed;
                @SlowSpeed.performed += instance.OnSlowSpeed;
                @SlowSpeed.canceled += instance.OnSlowSpeed;
                @Ascend.started += instance.OnAscend;
                @Ascend.performed += instance.OnAscend;
                @Ascend.canceled += instance.OnAscend;
                @Descend.started += instance.OnDescend;
                @Descend.performed += instance.OnDescend;
                @Descend.canceled += instance.OnDescend;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LeaveDebug.started += instance.OnLeaveDebug;
                @LeaveDebug.performed += instance.OnLeaveDebug;
                @LeaveDebug.canceled += instance.OnLeaveDebug;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnUseTool(InputAction.CallbackContext context);
        void OnUseToolSecondary(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnAnalitics(InputAction.CallbackContext context);
        void OnEquipFlashlight(InputAction.CallbackContext context);
        void OnEquipGravitygun(InputAction.CallbackContext context);
        void OnEnterDebug(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnAnalitics(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnFastSpeed(InputAction.CallbackContext context);
        void OnSlowSpeed(InputAction.CallbackContext context);
        void OnAscend(InputAction.CallbackContext context);
        void OnDescend(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLeaveDebug(InputAction.CallbackContext context);
    }
}
