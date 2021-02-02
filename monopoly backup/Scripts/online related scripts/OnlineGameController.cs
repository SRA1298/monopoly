using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OnlineGameController : MonoBehaviour
{
    public static OnlineGameController onlinegamecontrollerinstance;

    [SerializeField] private string Version = "0.2";
    [SerializeField] private GameObject UsernamePanel;
    [SerializeField] private GameObject CreateRoomPanel;

    [SerializeField] private InputField usernameinput;
    [SerializeField] private InputField createinput;
    [SerializeField] private InputField joininput;

    [SerializeField] private GameObject Enterbutton;

    [HideInInspector] public bool forplayer1 = false;
    [HideInInspector] public bool forplayer2 = false;
    [HideInInspector] public string playername;
   

    private void Awake()
    {
        makeinstance();

        PhotonNetwork.automaticallySyncScene = true;
        PhotonNetwork.ConnectUsingSettings(Version);
    }

    void makeinstance()
    {
        if(onlinegamecontrollerinstance == null)
        {
            onlinegamecontrollerinstance = this;
        }
    }
    private void Start()
    {
        CreateRoomPanel.SetActive(false);
        Enterbutton.SetActive(false);

    }
    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected");
    }

    public void ChangeUserNameInput()
    {
        if (usernameinput.text.Length >= 3)
        {
            Enterbutton.SetActive(true);
        }
        else
        {
            Enterbutton.SetActive(false);
        }
    }

    public void EnterButtonFunction()
    {
        UsernamePanel.SetActive(false);
        CreateRoomPanel.SetActive(true);
        PhotonNetwork.playerName = usernameinput.text;
        playername = usernameinput.text;

    }

    public void CreateGame()
    {
        forplayer1 = true;
        PhotonNetwork.CreateRoom(createinput.text, new RoomOptions() { MaxPlayers = 4 }, null);
    }

    public void JoinGame()
    {
        forplayer2 = true;
        
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(createinput.text, roomOptions, TypedLobby.Default);
    }

    private void OnJoinedRoom()
    {
        if (PhotonNetwork.isMasterClient)
        {
           
            if (menuscripts.menuinstance.gameisonline == true && menuscripts.menuinstance.istimer == true)
            {
                PhotonNetwork.LoadLevel("online UI - Copy 1");
            }
            if (menuscripts.menuinstance.gameisonline == true && menuscripts.menuinstance.istimer == false)
            {
                PhotonNetwork.LoadLevel("online Classic 1");
            }


        }
       
    }
}
