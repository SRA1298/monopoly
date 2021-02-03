using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{
    public static PlayerSelection instance;

    [HideInInspector]
    public int player;

    public GameObject[] playernames;

    public GameObject sliderfortime;
    public GameObject moneyslider;


    [HideInInspector] public string player1name, player2name, player3name, player4name;
    public GameObject inputfield1, inputfield2, inputfield3, inputfield4;
    

    void Awake()
    {
        makeinstance();
        for(int i = 0; i < playernames.Length; i++)
        {
            playernames[i].transform.gameObject.SetActive(false);
        }

        if(menuscripts.menuinstance.gameisonline == true && menuscripts.menuinstance.forjoinmoneyslider == true)
        {
            moneyslider.transform.gameObject.SetActive(false);
            sliderfortime.transform.gameObject.SetActive(false);

        }

    }

    void makeinstance()
    {
        if (instance == null) 
        {
            instance = this;
        }
    }
    
    public void TwoPlayers()
    {
        player = 2;
        playernames[1].transform.gameObject.SetActive(true);
        playernames[2].transform.gameObject.SetActive(true);
        playernames[3].transform.gameObject.SetActive(false);
        playernames[4].transform.gameObject.SetActive(false);
    }

    public void ThreePlayers()
    {
        player = 3;
        playernames[1].transform.gameObject.SetActive(true);
        playernames[2].transform.gameObject.SetActive(true);
        playernames[3].transform.gameObject.SetActive(true);
        playernames[4].transform.gameObject.SetActive(false);
    }

    public void FourPlayers()
    {
        player = 4;
        playernames[1].transform.gameObject.SetActive(true);
        playernames[2].transform.gameObject.SetActive(true);
        playernames[3].transform.gameObject.SetActive(true);
        playernames[4].transform.gameObject.SetActive(true);

    }

    public void PlayGame()
    {
        player1name = inputfield1.GetComponent<Text>().text;
        player2name = inputfield2.GetComponent<Text>().text;
        player3name = inputfield3.GetComponent<Text>().text;
        player4name = inputfield4.GetComponent<Text>().text;


        SceneManager.LoadScene("monopoly");

        
    }


    /// the function from this point belong to online version
    [PunRPC]
    public void onlineTwoPlayers()
    {
        player = 2;
       
    }
    [PunRPC]
    public void onlineThreePlayers()
    {
        player = 3;
       
    }
    [PunRPC]
    public void onlineFourPlayers()
    {
        player = 4;
      

    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(player);
            //stream.SendNext(menuscripts.menuinstance.istimer);
           

        }
        else if (stream.isReading)
        {
            player = (int)stream.ReceiveNext();
            //menuscripts.menuinstance.istimer = (bool)stream.ReceiveNext();
            

        }
    }





    [PunRPC]
    public void onlinePlayGame()
    {

        PhotonNetwork.LoadLevel("online monopoly");

        //SceneManager.LoadScene("Get Username");


    }
}
