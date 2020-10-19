using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerLobbyBoard : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject playerPannel;
    [SerializeField] private Transform[] places;
    private int playerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        PlayerJoinedLobby();
    }

    // Update is called once per frame
    
    private void PlayerJoinedLobby()
    {
        PhotonNetwork.Instantiate(playerPannel.name, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public Vector3 GetPlayerBoardPosition()
    {
        return places[playerCount].localPosition;
    }
    public void AddPlayerCount()
    {
        playerCount++;
    }

    public void setReady()
    {
        GameObject.Find(PhotonNetwork.LocalPlayer.NickName).GetComponentInChildren<ReadyUp>().ButtonReadyUp();
    }
}
