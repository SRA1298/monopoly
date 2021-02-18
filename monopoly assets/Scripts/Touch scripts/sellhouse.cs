using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellhouse : MonoBehaviour
{
    public static sellhouse sellhouseinstance;

    public GameObject sellhousepanel;

    [HideInInspector]
    public bool clickedsellhouse;

    [HideInInspector]
    float[] sellhousevalue = new float[5];

    public PhotonView photonview;

     void Awake()
    {
        makeinstance();
        sellhousepanel.transform.gameObject.SetActive(false);
    }

    void makeinstance()
    {
        if(sellhouseinstance == null)
        {
            sellhouseinstance = this;
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 300.0f))
            {
                if (clickedsellhouse == true)
                {
                    sellhousefunction(hit.transform.gameObject);
                }
                else
                {
                   // print("no operation");
                }
            }
        }
    }


    public void sellhousefunction(GameObject go)
    {
        if (go.name == "Tile 1")
        {
            sellhousehandler(1);

        }
        if (go.name == "Tile 3")
        {
            sellhousehandler(3);

        }
        //if (go.name == "Tile 5")
        //{
        //    buyhousehandler(5);

        //}
        if (go.name == "Tile 6")
        {
            sellhousehandler(6);

        }
        if (go.name == "Tile 8")
        {
            sellhousehandler(8);

        }
        if (go.name == "Tile 9")
        {
            sellhousehandler(9);

        }
        if (go.name == "Tile 11")
        {
            sellhousehandler(11);

        }
        //if (go.name == "Tile 12")
        //{
        //    buyhousehandler(12);

        //}
        if (go.name == "Tile 13")
        {
            sellhousehandler(13);

        }
        if (go.name == "Tile 14")
        {
            sellhousehandler(14);

        }
        //if (go.name == "Tile 15")
        //{
        //    buyhousehandler(15);

        //}
        if (go.name == "Tile 16")
        {
            sellhousehandler(16);

        }
        if (go.name == "Tile 18")
        {
            sellhousehandler(18);

        }
        if (go.name == "Tile 19")
        {
            sellhousehandler(19);

        }
        if (go.name == "Tile 21")
        {
            sellhousehandler(21);

        }
        if (go.name == "Tile 23")
        {
            sellhousehandler(23);

        }
        if (go.name == "Tile 24")
        {
            sellhousehandler(24);

        }
        //if (go.name == "Tile 25")
        //{
        //    buyhousehandler(25);

        //}
        if (go.name == "Tile 26")
        {
            sellhousehandler(26);

        }
        if (go.name == "Tile 27")
        {
            sellhousehandler(27);

        }
        //if (go.name == "Tile 28")
        //{
        //    buyhousehandler(28);

        //}
        if (go.name == "Tile 29")
        {
            sellhousehandler(29);

        }
        if (go.name == "Tile 31")
        {
            sellhousehandler(31);

        }
        if (go.name == "Tile 32")
        {
            sellhousehandler(32);

        }
        if (go.name == "Tile 34")
        {
            sellhousehandler(34);

        }
        //if (go.name == "Tile 35")
        //{
        //    buyhousehandler(35);

        //}
        if (go.name == "Tile 37")
        {
            sellhousehandler(37);

        }
        if (go.name == "Tile 39")
        {
            sellhousehandler(39);

        }

    }

    void sellhousehandler(int w)
    {
        if (PanelManager.instance.cityblockhandler[w] == true && mortgage.mortgageinstance.Ismortgage[w] == false)
        {
            if (DiceManager.Diceinstance.playerturn == 1 && PanelManager.instance.buyedby[w] == 1)
            {
                sellhousevalue[1] = sellhousefunction(w, 1);
                PanelManager.instance.player1M += sellhousevalue[1];
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                sellhousevalue[1] = 0;

            }

            if (DiceManager.Diceinstance.playerturn == 2 && PanelManager.instance.buyedby[w] == 2)
            {
                sellhousevalue[2] = sellhousefunction(w, 2);
                PanelManager.instance.player2M += sellhousevalue[2];
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                sellhousevalue[2] = 0;

            }

            if (DiceManager.Diceinstance.playerturn == 3 && PanelManager.instance.buyedby[w] == 3)
            {
                sellhousevalue[3] = sellhousefunction(w, 3);
                PanelManager.instance.player3M += sellhousevalue[3];
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                sellhousevalue[3] = 0;


            }

            if (DiceManager.Diceinstance.playerturn == 4 && PanelManager.instance.buyedby[w] == 4)
            {
                sellhousevalue[4] = sellhousefunction(w, 4);
                PanelManager.instance.player4M += sellhousevalue[4];
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                sellhousevalue[4] = 0;

            }

            if(Buyhouse.buyhouseinstance.numberofhouse[w] > 0)
            {
                Buyhouse.buyhouseinstance.numberofhouse[w] -= 1;

                if(Buyhouse.buyhouseinstance.numberofhouse[w] == -1)
                {
                    Buyhouse.buyhouseinstance.numberofhouse[w] += 1;
                }
            }
        }
    }

    float sellhousefunction(int q, int sellvalue)
    {

        // this below if statement is used for the offline version of monopoly
        if(menuscripts.menuinstance.gameisonline == false)
        {
            // to delete house
            if (Buyhouse.buyhouseinstance.numberofhouse[q] == 5)
            {
                Buyhouse.buyhouseinstance.symbolhouse1[q].SetActive(true);
                Buyhouse.buyhouseinstance.symbolhouse2[q].SetActive(true);
                Buyhouse.buyhouseinstance.symbolhouse3[q].SetActive(true);
                Buyhouse.buyhouseinstance.symbolhouse4[q].SetActive(true);
                Buyhouse.buyhouseinstance.symbolhotel[q].SetActive(false);
                if (q < 10)
                {
                    sellhousevalue[sellvalue] = 25;
                }
                if (q > 10 && q < 20)
                {
                    sellhousevalue[sellvalue] = 50;
                }
                if (q > 20 && q < 30)
                {
                    sellhousevalue[sellvalue] = 75;
                }
                if (q > 30 && q < 40)
                {
                    sellhousevalue[sellvalue] = 100;
                }
            }
            // to delete house 4
            if (Buyhouse.buyhouseinstance.numberofhouse[q] == 4)
            {
                Buyhouse.buyhouseinstance.symbolhouse4[q].SetActive(false);
                if (q < 10)
                {
                    sellhousevalue[sellvalue] = 25;
                }
                if (q > 10 && q < 20)
                {
                    sellhousevalue[sellvalue] = 50;
                }
                if (q > 20 && q < 30)
                {
                    sellhousevalue[sellvalue] = 75;
                }
                if (q > 30 && q < 40)
                {
                    sellhousevalue[sellvalue] = 100;
                }
            }
            // to delete house 3
            if (Buyhouse.buyhouseinstance.numberofhouse[q] == 3)
            {
                Buyhouse.buyhouseinstance.symbolhouse3[q].SetActive(false);
                if (q < 10)
                {
                    sellhousevalue[sellvalue] = 25;
                }
                if (q > 10 && q < 20)
                {
                    sellhousevalue[sellvalue] = 50;
                }
                if (q > 20 && q < 30)
                {
                    sellhousevalue[sellvalue] = 75;
                }
                if (q > 30 && q < 40)
                {
                    sellhousevalue[sellvalue] = 100;
                }
            }
            // to delete house 2
            if (Buyhouse.buyhouseinstance.numberofhouse[q] == 2)
            {
                Buyhouse.buyhouseinstance.symbolhouse2[q].SetActive(false);
                if (q < 10)
                {
                    sellhousevalue[sellvalue] = 25;
                }
                if (q > 10 && q < 20)
                {
                    sellhousevalue[sellvalue] = 50;
                }
                if (q > 20 && q < 30)
                {
                    sellhousevalue[sellvalue] = 75;
                }
                if (q > 30 && q < 40)
                {
                    sellhousevalue[sellvalue] = 100;
                }
            }
            // to delete house 1
            if (Buyhouse.buyhouseinstance.numberofhouse[q] == 1)
            {
                Buyhouse.buyhouseinstance.symbolhouse1[q].SetActive(false);
                if (q < 10)
                {
                    sellhousevalue[sellvalue] = 25;
                }
                if (q > 10 && q < 20)
                {
                    sellhousevalue[sellvalue] = 50;
                }
                if (q > 20 && q < 30)
                {
                    sellhousevalue[sellvalue] = 75;
                }
                if (q > 30 && q < 40)
                {
                    sellhousevalue[sellvalue] = 100;
                }
            }
        }

        // the below if statement is the online version of monopoly
        if(menuscripts.menuinstance.gameisonline == true)
        {
            if (photonview.isMine)
            {
                // to delete house
                if (Buyhouse.buyhouseinstance.numberofhouse[q] == 5)
                {
                    Buyhouse.buyhouseinstance.symbolhouse1[q].SetActive(true);
                    Buyhouse.buyhouseinstance.symbolhouse2[q].SetActive(true);
                    Buyhouse.buyhouseinstance.symbolhouse3[q].SetActive(true);
                    Buyhouse.buyhouseinstance.symbolhouse4[q].SetActive(true);
                    Buyhouse.buyhouseinstance.symbolhotel[q].SetActive(false);
                    if (q < 10)
                    {
                        sellhousevalue[sellvalue] = 25;
                    }
                    if (q > 10 && q < 20)
                    {
                        sellhousevalue[sellvalue] = 50;
                    }
                    if (q > 20 && q < 30)
                    {
                        sellhousevalue[sellvalue] = 75;
                    }
                    if (q > 30 && q < 40)
                    {
                        sellhousevalue[sellvalue] = 100;
                    }
                }
                // to delete house 4
                if (Buyhouse.buyhouseinstance.numberofhouse[q] == 4)
                {
                    Buyhouse.buyhouseinstance.symbolhouse4[q].SetActive(false);
                    if (q < 10)
                    {
                        sellhousevalue[sellvalue] = 25;
                    }
                    if (q > 10 && q < 20)
                    {
                        sellhousevalue[sellvalue] = 50;
                    }
                    if (q > 20 && q < 30)
                    {
                        sellhousevalue[sellvalue] = 75;
                    }
                    if (q > 30 && q < 40)
                    {
                        sellhousevalue[sellvalue] = 100;
                    }
                }
                // to delete house 3
                if (Buyhouse.buyhouseinstance.numberofhouse[q] == 3)
                {
                    Buyhouse.buyhouseinstance.symbolhouse3[q].SetActive(false);
                    if (q < 10)
                    {
                        sellhousevalue[sellvalue] = 25;
                    }
                    if (q > 10 && q < 20)
                    {
                        sellhousevalue[sellvalue] = 50;
                    }
                    if (q > 20 && q < 30)
                    {
                        sellhousevalue[sellvalue] = 75;
                    }
                    if (q > 30 && q < 40)
                    {
                        sellhousevalue[sellvalue] = 100;
                    }
                }
                // to delete house 2
                if (Buyhouse.buyhouseinstance.numberofhouse[q] == 2)
                {
                    Buyhouse.buyhouseinstance.symbolhouse2[q].SetActive(false);
                    if (q < 10)
                    {
                        sellhousevalue[sellvalue] = 25;
                    }
                    if (q > 10 && q < 20)
                    {
                        sellhousevalue[sellvalue] = 50;
                    }
                    if (q > 20 && q < 30)
                    {
                        sellhousevalue[sellvalue] = 75;
                    }
                    if (q > 30 && q < 40)
                    {
                        sellhousevalue[sellvalue] = 100;
                    }
                }
                // to delete house 1
                if (Buyhouse.buyhouseinstance.numberofhouse[q] == 1)
                {
                    Buyhouse.buyhouseinstance.symbolhouse1[q].SetActive(false);
                    if (q < 10)
                    {
                        sellhousevalue[sellvalue] = 25;
                    }
                    if (q > 10 && q < 20)
                    {
                        sellhousevalue[sellvalue] = 50;
                    }
                    if (q > 20 && q < 30)
                    {
                        sellhousevalue[sellvalue] = 75;
                    }
                    if (q > 30 && q < 40)
                    {
                        sellhousevalue[sellvalue] = 100;
                    }
                }
            }
        }

        

        return (sellhousevalue[sellvalue]);
    }

    public void closesellhousepanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        clickedsellhouse = false;
        sellhousepanel.transform.gameObject.SetActive(false);
    }
}
