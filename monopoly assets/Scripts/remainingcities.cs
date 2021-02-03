using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remainingcities : MonoBehaviour
{
    public GameObject[] remainingcityimage;
    public GameObject remainingcitypanel;

    public GameObject[] texthandler;
    private void Awake()
    {
        remainingcitypanel.transform.gameObject.SetActive(false);
        for (int i = 0; i < remainingcityimage.Length; i++)
        {
            remainingcityimage[i].transform.gameObject.SetActive(false);
        }
        for (int i = 0; i < texthandler.Length; i++)
        {
            texthandler[i].transform.gameObject.SetActive(false);
        }

    }

    public void remainingcity()
    {
        if(DiceManager.Diceinstance.playerturn == 1)
        {
            remainingforplayer1();
        }
        if(DiceManager.Diceinstance.playerturn == 2)
        {
            remainingforplayer2();
        }
        if(DiceManager.Diceinstance.playerturn == 3)
        {
            remainingforplayer3();
        }
        if(DiceManager.Diceinstance.playerturn == 4)
        {
            remainingforplayer4();
        }
    }
    public void remainingforplayer1()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;
        remainingcitypanel.transform.gameObject.SetActive(true);
        texthandler[1].transform.gameObject.SetActive(true);
        for (int i = 1; i <= 40; i++)
        {
           if (PanelManager.instance.cityblockhandler[i] == false && PanelManager.instance.player1M > PanelManager.instance.buyValue[i])
            {
                remainingcityimage[i].transform.gameObject.SetActive(true);
            }
        }
    }

    public void remainingforplayer2()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;
        remainingcitypanel.transform.gameObject.SetActive(true);
        texthandler[2].transform.gameObject.SetActive(true);
        for (int i = 1; i <= 40; i++)
        {
            if (PanelManager.instance.cityblockhandler[i] == false && PanelManager.instance.player2M > PanelManager.instance.buyValue[i])
            {
                remainingcityimage[i].transform.gameObject.SetActive(true);
            }
        }
    }

    public void remainingforplayer3()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;
        remainingcitypanel.transform.gameObject.SetActive(true);
        texthandler[3].transform.gameObject.SetActive(true);
        for (int i = 1; i <= 40; i++)
        {
            if (PanelManager.instance.cityblockhandler[i] == false && PanelManager.instance.player3M > PanelManager.instance.buyValue[i])
            {
                remainingcityimage[i].transform.gameObject.SetActive(true);
            }
        }
    }

    public void remainingforplayer4()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;
        remainingcitypanel.transform.gameObject.SetActive(true);
        texthandler[4].transform.gameObject.SetActive(true);
        for (int i = 1; i <= 40; i++)
        {
            if (PanelManager.instance.cityblockhandler[i] == false && PanelManager.instance.player4M > PanelManager.instance.buyValue[i])
            {
                remainingcityimage[i].transform.gameObject.SetActive(true);
            }
        }
    }


    public void closeremainingpanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        remainingcitypanel.transform.gameObject.SetActive(false);
        for (int i = 0; i < remainingcityimage.Length; i++)
        {
            remainingcityimage[i].transform.gameObject.SetActive(false);
        }
        for (int i = 0; i < texthandler.Length; i++)
        {
            texthandler[i].transform.gameObject.SetActive(false);
        }
    }
}
