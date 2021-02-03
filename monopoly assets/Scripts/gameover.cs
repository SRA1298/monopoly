using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public static gameover gameoverinstance;
    [HideInInspector]
    public Text money1, money2, money3, money4, city1, city2, city3, city4;

    public GameObject gameoverpanel;

    public GameObject player3hide;
    public GameObject player4hide;

    public GameObject[] winnerimage = new GameObject[5];

    public GameObject quitpanel;
    void Awake()
    {
        makeinstance();
        gameoverpanel.transform.gameObject.SetActive(false);
       

        money1 = GameObject.Find("Money1").GetComponent<Text>();
       // money1.transform.gameObject.SetActive(false);
        money2 = GameObject.Find("Money2").GetComponent<Text>();
        money3 = GameObject.Find("Money3").GetComponent<Text>();
        money4 = GameObject.Find("Money4").GetComponent<Text>();
        city1 = GameObject.Find("City1").GetComponent<Text>();
        city2 = GameObject.Find("City2").GetComponent<Text>();
        city3 = GameObject.Find("City3").GetComponent<Text>();
        city4 = GameObject.Find("City4").GetComponent<Text>();

        quitpanel.transform.gameObject.SetActive(false);
        for(int i = 0; i < 5; i++)
        {
            winnerimage[i].transform.gameObject.SetActive(false);
        }

    }

    void makeinstance()
    {
        if (gameoverinstance == null)
        {
            gameoverinstance = this;
        }
    }


    public void gameoverfunction()
    {
        float totalplayer1 = 0, totalplayer2 = 0, totalplayer3 = 0, totalplayer4 = 0;
        gameoverpanel.transform.gameObject.SetActive(true);

        float player1money = (PanelManager.instance.player1M / ShowValue.showinstance.printvalue ) * 100;
        float player1city = (PanelManager.instance.player1counter / 24) * 100;
        totalplayer1 = player1money + player1city;

        float player2money = (PanelManager.instance.player2M / ShowValue.showinstance.printvalue) * 100;
        float player2city = (PanelManager.instance.player2counter / 24) * 100;
        totalplayer2 = player2money + player2city;

        if(PlayerSelection.instance.player == 3)
        {

            float player3money = (PanelManager.instance.player3M / ShowValue.showinstance.printvalue) * 100;
            float player3city = (PanelManager.instance.player3counter / 24) * 100;
            totalplayer3 = player3money + player3city;
        }

        if(PlayerSelection.instance.player == 4)
        {
            float player3money = (PanelManager.instance.player3M / ShowValue.showinstance.printvalue) * 100;
            float player3city = (PanelManager.instance.player3counter / 24) * 100;
            totalplayer3 = player3money + player3city;

            float player4money = (PanelManager.instance.player4M / ShowValue.showinstance.printvalue) * 100;
            float player4city = (PanelManager.instance.player4counter / 24) * 100;
            totalplayer4 = player4money + player4city;
        }

       

        if (totalplayer1 > totalplayer2)
        {
            if (totalplayer1 > totalplayer3)
            {
                if (totalplayer1 > totalplayer4)
                {
                    winnerimage[1].transform.gameObject.SetActive(true);
                }
            }
        }

        if (totalplayer2 > totalplayer1)
        {
            if (totalplayer2 > totalplayer3)
            {
                if (totalplayer2 > totalplayer4)
                {
                    winnerimage[2].transform.gameObject.SetActive(true);
                }
            }
        }

        if (totalplayer3 > totalplayer1)
        {
            if (totalplayer3 > totalplayer2)
            {
                if (totalplayer3 > totalplayer4)
                {
                    winnerimage[3].transform.gameObject.SetActive(true);
                }
            }
        }

        if (totalplayer4 > totalplayer1)
        {
            if (totalplayer4 > totalplayer2)
            {
                if (totalplayer4 > totalplayer3)
                {
                    winnerimage[4].transform.gameObject.SetActive(true);
                }
            }
        }

        money1.text = PanelManager.instance.player1M.ToString();
        money2.text = PanelManager.instance.player2M.ToString();
        money3.text = PanelManager.instance.player3M.ToString();
        money4.text = PanelManager.instance.player4M.ToString();
        city1.text = PanelManager.instance.player1counter.ToString();
        city2.text = PanelManager.instance.player2counter.ToString();
        city3.text = PanelManager.instance.player3counter.ToString();
        city4.text = PanelManager.instance.player4counter.ToString();

        if (PlayerSelection.instance.player == 2)
        {
            player3hide.transform.gameObject.SetActive(false);
            player4hide.transform.gameObject.SetActive(false);
            money3.transform.gameObject.SetActive(false);
            money4.transform.gameObject.SetActive(false);
            city3.transform.gameObject.SetActive(false);
            city4.transform.gameObject.SetActive(false);
        }

        if (PlayerSelection.instance.player == 3)
        {
            player4hide.transform.gameObject.SetActive(false);
            money4.transform.gameObject.SetActive(false);
            city4.transform.gameObject.SetActive(false);
        }
       




    }

    public void gobacktoui()
    {
        gameoverpanel.transform.gameObject.SetActive(false);
        SceneManager.LoadScene("mainmenu");
    }

    public void exitbutton()
    {
        quitpanel.transform.gameObject.SetActive(true);
    }
  
    public void Yesbutton()
    {
        SceneManager.LoadScene("mainmenu");
        
    }

    public void nobutton()
    {
        quitpanel.transform.gameObject.SetActive(false);
    }
   
}
