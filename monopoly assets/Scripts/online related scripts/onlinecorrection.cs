using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onlinecorrection : MonoBehaviour
{
    public static onlinecorrection onlinecorrectioninstance;

    public GameObject jailpanel;
    public GameObject rolldicepanel;
    public GameObject letsbeginpanel;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    [HideInInspector] public bool onlineplayerturn1 = false;
    [HideInInspector] public bool onlineplayerturn2 = false;
    [HideInInspector] public bool onlineplayerturn3 = false;
    [HideInInspector] public bool onlineplayerturn4 = false;


    public Text playername1;
    public Text playername2;
    public Text playername3;
    public Text playername4;

  
    private void Awake()
    {
        jailpanel.SetActive(false);
        rolldicepanel.SetActive(false);
       
        makeinstance();

       // onlinePlayerName.onlinePlayerNameinstance.onlineplayermoney();
       
    }


    void makeinstance()
    {
        if(onlinecorrectioninstance == null)
        {
            onlinecorrectioninstance = this;
        }
    }

    public void letsbeginbutton()
    {
        

        if (OnlineGameController.onlinegamecontrollerinstance.forplayer1 == true)
        {
            
            PhotonNetwork.Instantiate(player1.name, new Vector3(-0.23f, 0, -0.29f), Quaternion.identity, 0);
            followscripts.camerainstance.onlinecameramovemnetforplayer1();
            onlineplayerturn1 = true;
            playername1.text = PhotonNetwork.playerName;

        }
        if (OnlineGameController.onlinegamecontrollerinstance.forplayer2 == true)
        {
            if (GameObject.Find("Red(Clone)") != null)
            {
                PhotonNetwork.Instantiate(player4.name, new Vector3(0.23f, 0, 0.06f), Quaternion.identity, 0);
                followscripts.camerainstance.onlinecameramovemnetforplayer4();
                onlineplayerturn4 = true;
                playername4.text = PhotonNetwork.playerName;
            }
            else if (GameObject.Find("Green(Clone)") != null)
            {
                PhotonNetwork.Instantiate(player3.name, new Vector3(-0.21f, 0, 0.06f), Quaternion.identity, 0);
                followscripts.camerainstance.onlinecameramovemnetforplayer3();
                onlineplayerturn3 = true;
                playername3.text = PhotonNetwork.playerName;
            }
            else if (GameObject.Find("Blue(Clone)") != null)
            {
                PhotonNetwork.Instantiate(player2.name, new Vector3(0.23f, 0, -0.29f), Quaternion.identity, 0);
                followscripts.camerainstance.onlinecameramovemnetforplayer2();
                onlineplayerturn2 = true;
                playername2.text = PhotonNetwork.playerName;
            }
            else
            {
                print("just for player spwaning");
            }
            
        }

        letsbeginpanel.transform.gameObject.SetActive(false);

    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
           
            stream.SendNext(playername1.text);
            stream.SendNext(playername2.text);
            stream.SendNext(playername3.text);
            stream.SendNext(playername4.text);

        }
        else if (stream.isReading)
        {
           
            playername1.text = (string)stream.ReceiveNext();
            playername2.text = (string)stream.ReceiveNext();
            playername3.text = (string)stream.ReceiveNext();
            playername4.text = (string)stream.ReceiveNext();

        }
    }

}
