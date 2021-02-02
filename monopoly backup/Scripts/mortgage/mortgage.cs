using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mortgage : MonoBehaviour
{
    public static mortgage mortgageinstance;
    [HideInInspector]
    public bool mortgagebuttonclicked = false;
    public GameObject mortgagepanel;

    [HideInInspector]
    public bool[] Ismortgage = new bool[45];

    void Awake()
    {
        makeinstance();
        mortgagepanel.transform.gameObject.SetActive(false);
        for (int i = 0; i < 44; i++)
        {
            Ismortgage[i] = false;
        }
    }

    void makeinstance()
    {
        if(mortgageinstance == null)
        {
            mortgageinstance = this;
        }
    }
    private void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 200.0f))
            {
                if (mortgagebuttonclicked == true)
                {
                    mortgagefuntion(hit.transform.gameObject);
                }
                else
                {
                   // print("no operation for mortgage");
                }
            }
        }
    }

    public void mortgagefuntion(GameObject go)
    {
        if (go.name == "Tile 1")
        {
            mortgageplayervaluehandler(1);

        }
        if (go.name == "Tile 3")
        {
            mortgageplayervaluehandler(3);

        }
        if (go.name == "Tile 5")
        {
            mortgageplayervaluehandler(5);

        }
        if (go.name == "Tile 6")
        {
            mortgageplayervaluehandler(6);

        }
        if (go.name == "Tile 8")
        {
            mortgageplayervaluehandler(8);

        }
        if (go.name == "Tile 9")
        {
            mortgageplayervaluehandler(9);

        }
        if (go.name == "Tile 11")
        {
            mortgageplayervaluehandler(11);

        }
        if (go.name == "Tile 12")
        {
            mortgageplayervaluehandler(12);

        }
        if (go.name == "Tile 13")
        {
            mortgageplayervaluehandler(13);

        }
        if (go.name == "Tile 14")
        {
            mortgageplayervaluehandler(14);

        }
        if (go.name == "Tile 15")
        {
            mortgageplayervaluehandler(15);

        }
        if (go.name == "Tile 16")
        {
            mortgageplayervaluehandler(16);

        }
        if (go.name == "Tile 18")
        {
            mortgageplayervaluehandler(18);

        }
        if (go.name == "Tile 19")
        {
            mortgageplayervaluehandler(19);

        }
        if (go.name == "Tile 21")
        {
            mortgageplayervaluehandler(21);

        }
        if (go.name == "Tile 23")
        {
            mortgageplayervaluehandler(23);

        }
        if (go.name == "Tile 24")
        {
            mortgageplayervaluehandler(24);

        }
        if (go.name == "Tile 25")
        {
            mortgageplayervaluehandler(25);

        }
        if (go.name == "Tile 26")
        {
            mortgageplayervaluehandler(26);

        }
        if (go.name == "Tile 27")
        {
            mortgageplayervaluehandler(27);

        }
        if (go.name == "Tile 28")
        {
            mortgageplayervaluehandler(28);

        }
        if (go.name == "Tile 29")
        {
            mortgageplayervaluehandler(29);

        }
        if (go.name == "Tile 31")
        {
            mortgageplayervaluehandler(31);

        }
        if (go.name == "Tile 32")
        {
            mortgageplayervaluehandler(32);

        }
        if (go.name == "Tile 34")
        {
            mortgageplayervaluehandler(34);

        }
        if (go.name == "Tile 35")
        {
            mortgageplayervaluehandler(35);

        }
        if (go.name == "Tile 37")
        {
            mortgageplayervaluehandler(37);

        }
        if (go.name == "Tile 39")
        {
            mortgageplayervaluehandler(39);

        }

    }

    void mortgageplayervaluehandler(int i)
    {
        if (PanelManager.instance.cityblockhandler[i] == true && Ismortgage[i] == false)
        {
            Ismortgage[i] = true;
            if (DiceManager.Diceinstance.playerturn == 1 && PanelManager.instance.buyedby[i] == 1)
            {
                PanelManager.instance.player1M += PanelManager.instance.buyValue[i] / 2;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 2 && PanelManager.instance.buyedby[i] == 2)
            {
                PanelManager.instance.player2M += PanelManager.instance.buyValue[i] / 2;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 3 && PanelManager.instance.buyedby[i] == 3)
            {
                PanelManager.instance.player3M += PanelManager.instance.buyValue[i] / 2;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 4 && PanelManager.instance.buyedby[i] == 4)
            {
                PanelManager.instance.player4M += PanelManager.instance.buyValue[i] / 2;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
            }
           
        }
    }

    public void closemortgagepanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        mortgagebuttonclicked = false;
        mortgagepanel.transform.gameObject.SetActive(false);

    }

}
