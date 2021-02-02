using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercities : MonoBehaviour
{
    public static playercities playercitiesinstance;

    public GameObject[] cityimage;
    public GameObject playercitypanel;
    public GameObject[] playername;

    private void Awake()
    {
        makeinstance();
        playercitypanel.transform.gameObject.SetActive(false);
        for(int i = 0; i < cityimage.Length; i++)
        {
            cityimage[i].transform.gameObject.SetActive(false);
        }
        for (int s = 0; s < playername.Length; s++)
        {
            playername[s].transform.gameObject.SetActive(false);
        }

    }

    void makeinstance()
    {
        if(playercitiesinstance == null)
        {
            playercitiesinstance = this;
        }
    }
    public void player1cities()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // used to stop the click on property
        playercitypanel.transform.gameObject.SetActive(true);
        playername[1].transform.gameObject.SetActive(true);
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    cityimage[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void player2cities()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // used to stop the click on property
        playercitypanel.transform.gameObject.SetActive(true);
        playername[2].transform.gameObject.SetActive(true);
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    cityimage[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void player3cities()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // used to stop the click on property
        playercitypanel.transform.gameObject.SetActive(true);
        playername[3].transform.gameObject.SetActive(true);
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    cityimage[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void player4cities()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // used to stop the click on property
        playercitypanel.transform.gameObject.SetActive(true);
        playername[4].transform.gameObject.SetActive(true);
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    cityimage[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void closeplayercitypanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        playercitypanel.transform.gameObject.SetActive(false);
        for (int i = 0; i < cityimage.Length; i++)
        {
            cityimage[i].transform.gameObject.SetActive(false);
        }
        for (int s = 0; s < playername.Length; s++)
        {
            playername[s].transform.gameObject.SetActive(false);
        }

    }

}





