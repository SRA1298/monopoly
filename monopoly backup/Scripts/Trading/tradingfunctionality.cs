using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tradingfunctionality : MonoBehaviour
{
    public static tradingfunctionality tradinginstance;

    //show the city which belong to which player for trading
    public GameObject[] leftplayercity;
    public GameObject[] rightplayercity;

    private void Awake()
    {
        makeinstance();

        for(int i = 0; i < leftplayercity.Length; i++)
        {
            leftplayercity[i].transform.gameObject.SetActive(false);
        }

        for (int i = 0; i < rightplayercity.Length; i++)
        {
            rightplayercity[i].transform.gameObject.SetActive(false);
        }
    }

    void makeinstance()
    {
        if(tradinginstance == null)
        {
            tradinginstance = this;
        }
    }

    public void tradingpanelfunctionp1b2()
    {
        for(int i = 0; i <= 40; i++)
        {
            for(int j = 0; j <= 40 ; j++)
            {
                if(PanelManager.instance.citylistofplayer1[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

    }

    public void tradingpanelfunctionp1b3()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp1b4()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp2b1()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp2b3()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp2b4()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp3b1()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp3b2()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp3b4()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp4b1()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer1[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp4b2()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer2[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    public void tradingpanelfunctionp4b3()
    {
        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer4[i] == j)
                {
                    leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 0; j <= 40; j++)
            {
                if (PanelManager.instance.citylistofplayer3[i] == j)
                {
                    rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }

    
}
