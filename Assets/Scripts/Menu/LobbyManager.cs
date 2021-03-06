﻿using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public static LobbyManager instance;
    
    public Text textLog;

    [SerializeField]
    private GameObject readyButton;
    [SerializeField]
    private GameObject unreadyButton;

    [SerializeField] private TMP_Text lobbyName;

    private List<string> log;
    private AudioSource _audio;

    private int readyNum = 0;
    private readonly byte PlayerReadyEvent = 2;

    [SerializeField] private AudioClip countdownBeep;
    [SerializeField] private AudioClip finalBeep;


    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;

        _audio = GetComponent<AudioSource>();
        log = new List<string>();
        lobbyName.text = NetworkManager.instance.RoomName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateLog(string newLine)
    {
        log.Add(newLine);
        
        string l = "";
        foreach (string line in log)
        {
            l += line + "\n";
        }

        textLog.text = l;
    }
    
    public void LeaveLobby()
    {
        NetworkManager.instance.LeaveLobby();
    }

    public void OnReadyPressed()
    {
        readyButton.SetActive(false);
        unreadyButton.SetActive(true);
        //NetworkManager.instance.triggerReadyRPC("PlayerReadied", PhotonNetwork.LocalPlayer);
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.All }; // You would have to set the Receivers to All in order to receive this event on the local client as well
        SendOptions sendOptions = new SendOptions { Reliability = true };
        Debug.Log("Raised Ready event");
        PhotonNetwork.RaiseEvent(PlayerReadyEvent, true, raiseEventOptions,
            sendOptions);
    }
    public void OnUnreadyPressed()
    {
        readyButton.SetActive(true);
        unreadyButton.SetActive(false);
        //NetworkManager.instance.triggerReadyRPC("PlayerUnreadied", PhotonNetwork.LocalPlayer);
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.All }; // You would have to set the Receivers to All in order to receive this event on the local client as well
        SendOptions sendOptions = new SendOptions { Reliability = true };
        Debug.Log("Raised Unready event");
        PhotonNetwork.RaiseEvent(PlayerReadyEvent, false, raiseEventOptions,
            sendOptions);
    }
    
    public void ReadyPlayer()
    {
        readyNum++;
        updateLog("Player " + PhotonNetwork.LocalPlayer.NickName + " readied up!");
        if (readyNum == 2)
        {
            updateLog("All players are ready!");
            StartCoroutine(StartGameCountdown(5)); // Start game in 5 seconds
        }

    }

    public void UnreadyPlayer()
    {
        readyNum--;
        updateLog("Player " + PhotonNetwork.LocalPlayer.NickName + " disabled ready!");
        if (readyNum == 1)
        {
            updateLog("Players no longer ready!");
        }
    }

    IEnumerator StartGameCountdown(int timeToStart)
    {
        while (true)
        {
            if (readyNum < 2)
            {
                updateLog("Game start cancelled!");
                break;
            }
            if (timeToStart == 0)
            {
                //Start Game
                PlaySound(finalBeep);
                if(PhotonNetwork.IsMasterClient)
                    StartGame();
                Debug.Log("Game has started!");
                break;
            }
            else
            {
                updateLog("Game starting in " + timeToStart + " seconds!");
                PlaySound(countdownBeep);
                timeToStart--;
                yield return new WaitForSeconds(1);
            }
        }
    }

    private void PlaySound(AudioClip sound)
    {
        _audio.PlayOneShot(sound);
    }

    void StartGame()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
