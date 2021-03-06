﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Photon.Pun;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Puzzles")]
    [SerializeField]
    private List<GameObject> puzzles; // List of all puzzles
    private int nextPuzzleToSpawnIndex;
    private List<GameObject> spawnedPuzzles; // List of spawned and active;
    
    [SerializeField] 
    private List<Transform> puzzleSpawnList; 
    private int nextSpawnIndex = 0;
    
    private PuzzleRoom nextPuzzle; // Script of next puzzle
    
    [Header("Player settings")]
    [SerializeField]
    private GameObject LocalPlayerPrefab;

    [Header("Game References")]
    [SerializeField]
    private Transform masterSpawnPoint;
    [SerializeField]
    private Transform initialMasterSpawnPoint;
    [SerializeField]
    private Transform clientSpawnPoint;
    [SerializeField]
    private Transform initialClientSpawnPoint;

    public Teleport nextPortal;

    [Header("UI")]
    public GameObject CanvasSpawned;


    [SerializeField]
    private GameObject endLevel;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;

        if (NetworkManager.instance == null)
        {
            PhotonNetwork.OfflineMode = true;
            Debug.LogError("OFFLINE MODE");
            LocalSpawnPlayers();
        }
        else
        {
            if(PhotonNetwork.IsMasterClient)
                NetworkManager.instance.LaunchSpawnPlayers();
        }

        //spawnedPuzzles = new List<GameObject>(puzzleSpawnList.Count);
        //SpawnPuzzleRooms(1);

        //nextPortal.SetPoints(nextPuzzle.MasterSpawnPoint, nextPuzzle.ClientSpawnPoint);
        //UpdateTeleport();
    }

    private void LocalSpawnPlayers()
    {
        Instantiate(LocalPlayerPrefab, masterSpawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPuzzleRooms(int howMany)
    {
        if (nextPuzzleToSpawnIndex >= puzzles.Count)
        {
            Debug.LogWarning("All puzzles have been spawned");
            //TODO: Do something here. Game will soon end
            GameObject endlevelInst = Instantiate(endLevel, puzzleSpawnList[nextSpawnIndex].position,
                puzzleSpawnList[nextSpawnIndex].rotation);
            nextPuzzle = endlevelInst.GetComponent<PuzzleRoom>();
            return;
        }
        
        for (int i = 0; i < howMany; i++)
        {
            if (nextPuzzleToSpawnIndex >= puzzles.Count || nextSpawnIndex >= puzzleSpawnList.Count)
                return;
            GameObject nextPuzzleObj = Instantiate(puzzles[nextPuzzleToSpawnIndex], puzzleSpawnList[nextSpawnIndex].position, Quaternion.identity);
            nextPuzzle = nextPuzzleObj.GetComponent<PuzzleRoom>();
            spawnedPuzzles.Insert(spawnedPuzzles.Count, nextPuzzleObj);
            nextPuzzleToSpawnIndex = ++nextPuzzleToSpawnIndex;
            nextSpawnIndex = ++nextSpawnIndex % puzzleSpawnList.Count;
        }
    }

    public void UpdateTeleport()
    {
        masterSpawnPoint = nextPuzzle.MasterSpawnPoint;
        clientSpawnPoint = nextPuzzle.ClientSpawnPoint;
        if (nextPortal == null)
        {
            Debug.Log("Couldn't find a portal", this);
            return;
        }

        nextPortal.SetPoints(masterSpawnPoint, clientSpawnPoint);
            
        nextPortal = nextPuzzle.Teleport;
    }

    public void SpawnPlayers()
    {
        //TODO: Spawn a general prefab without any models in it and let players handle it
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Master instantiated");
            PhotonNetwork.Instantiate(LocalPlayerPrefab.name, initialMasterSpawnPoint.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Client instantiated");
            PhotonNetwork.Instantiate(LocalPlayerPrefab.name, initialClientSpawnPoint.position, Quaternion.identity);;
        }
    }

    public void TeleportPlayer(Transform player)
    {
        player.position = PhotonNetwork.IsMasterClient? nextPuzzle.MasterSpawnPoint.position : nextPuzzle.ClientSpawnPoint.position;
    }

    public void DeletePuzzle()
    {
        if (spawnedPuzzles.Count <= 2)
        {
            Debug.LogError("Tried to delete the only puzzle remaining!");
            return;
        }
        
        int puzzleToDelete = spawnedPuzzles.Count - 3;

        Debug.Log("Tried to delete puzzle " + puzzleToDelete);
        Destroy(spawnedPuzzles[puzzleToDelete]);
        spawnedPuzzles.RemoveAt(puzzleToDelete);

    }
}
