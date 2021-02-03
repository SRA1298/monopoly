using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onlinePlayerName : MonoBehaviour
{
    public static onlinePlayerName onlinePlayerNameinstance;

    [HideInInspector] public float money;

    int numberofplayer;
    bool fortimer;

    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
     
    public void Awake()
    {
        if(OnlineGameController.onlinegamecontrollerinstance.forplayer1 == true)
        {
            fortimer = menuscripts.menuinstance.istimer;
            menuscripts.menuinstance.istimer = fortimer;
            money = ShowValue.showinstance.printvalue;
        }
       

        makeinstance();
    }

    void makeinstance()
    {
        if(onlinePlayerNameinstance == null)
        {
            onlinePlayerNameinstance = this;
        }
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(money);
            stream.SendNext(fortimer);
            

        }
        else if (stream.isReading)
        {
            money = (float)stream.ReceiveNext();
            fortimer = (bool)stream.ReceiveNext();
           

        }
        onlineplayermoney();
    }

    public void onlineplayermoney()
    {
        PanelManager.instance.player1M = money;
        player1.text = money.ToString();
        PanelManager.instance.player2M = money;
        player2.text = money.ToString();
        if (PlayerSelection.instance.player == 3)
        {
            PanelManager.instance.player3M = money;
            player3.text = money.ToString();
        }
        if (PlayerSelection.instance.player == 4)
        {
            PanelManager.instance.player3M = money;
            player3.text = money.ToString();
            PanelManager.instance.player4M = money;
            player4.text = money.ToString();
        }
    }

}
