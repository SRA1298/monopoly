using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redeemscripts : MonoBehaviour
{
    public static redeemscripts redeeminstance;

    public GameObject redeempanel;
    [HideInInspector]
    public bool redeembuttonclicked = false;

    [HideInInspector]
    public int[] redeemvalue = new int[40];

    void Awake()
    {
        makeinstance();
        redeempanel.transform.gameObject.SetActive(false);

        redeemvalue[1] = 33;
        redeemvalue[3] = 33;
        redeemvalue[5] = 110;
        redeemvalue[6] = 54;
        redeemvalue[8] = 54;
        redeemvalue[9] = 65;
        redeemvalue[11] = 75;
        redeemvalue[12] = 80;
        redeemvalue[13] = 75;
        redeemvalue[14] = 88;
        redeemvalue[15] = 110;
        redeemvalue[16] = 98;
        redeemvalue[18] = 98;
        redeemvalue[19] = 110;
        redeemvalue[21] = 122;
        redeemvalue[23] = 122;
        redeemvalue[24] = 134;
        redeemvalue[25] = 110;
        redeemvalue[26] = 145;
        redeemvalue[27] = 145;
        redeemvalue[28] = 80;
        redeemvalue[29] = 158;
        redeemvalue[31] = 170;
        redeemvalue[32] = 170;
        redeemvalue[34] = 175;
        redeemvalue[35] = 110;
        redeemvalue[37] = 195;
        redeemvalue[39] = 225;

    }

    void makeinstance()
    {
        if (redeeminstance == null)
        {
            redeeminstance = this;
        }
    }
    private void Update()
    {
        if ( Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 200.0f))
            {
                if (redeembuttonclicked == true ) 
                {
                    Redeemfunction(hit.transform.gameObject);
                }
                else
                {
                    //print("no operation for redeem ");
                }
            }
        }
    }

    public void Redeemfunction(GameObject go)
    {
        if (go.name == "Tile 1")
        {
            redeemplayervaluehandler(1);

        }
        if (go.name == "Tile 3")
        {
            redeemplayervaluehandler(3);

        }
        if (go.name == "Tile 5")
        {
            redeemplayervaluehandler(5);

        }
        if (go.name == "Tile 6")
        {
            redeemplayervaluehandler(6);

        }
        if (go.name == "Tile 8")
        {
            redeemplayervaluehandler(8);

        }
        if (go.name == "Tile 9")
        {
            redeemplayervaluehandler(9);

        }
        if (go.name == "Tile 11")
        {
            redeemplayervaluehandler(11);

        }
        if (go.name == "Tile 12")
        {
            redeemplayervaluehandler(12);

        }
        if (go.name == "Tile 13")
        {
            redeemplayervaluehandler(13);

        }
        if (go.name == "Tile 14")
        {
            redeemplayervaluehandler(14);

        }
        if (go.name == "Tile 15")
        {
            redeemplayervaluehandler(15);

        }
        if (go.name == "Tile 16")
        {
            redeemplayervaluehandler(16);

        }
        if (go.name == "Tile 18")
        {
            redeemplayervaluehandler(18);

        }
        if (go.name == "Tile 19")
        {
            redeemplayervaluehandler(19);

        }
        if (go.name == "Tile 21")
        {
            redeemplayervaluehandler(21);

        }
        if (go.name == "Tile 23")
        {
            redeemplayervaluehandler(23);

        }
        if (go.name == "Tile 24")
        {
            redeemplayervaluehandler(24);

        }
        if (go.name == "Tile 25")
        {
            redeemplayervaluehandler(25);

        }
        if (go.name == "Tile 26")
        {
            redeemplayervaluehandler(26);

        }
        if (go.name == "Tile 27")
        {
            redeemplayervaluehandler(27);

        }
        if (go.name == "Tile 28")
        {
            redeemplayervaluehandler(28);

        }
        if (go.name == "Tile 29")
        {
            redeemplayervaluehandler(29);

        }
        if (go.name == "Tile 31")
        {
            redeemplayervaluehandler(31);

        }
        if (go.name == "Tile 32")
        {
            redeemplayervaluehandler(32);

        }
        if (go.name == "Tile 34")
        {
            redeemplayervaluehandler(34);

        }
        if (go.name == "Tile 35")
        {
            redeemplayervaluehandler(35);

        }
        if (go.name == "Tile 37")
        {
            redeemplayervaluehandler(37);

        }
        if (go.name == "Tile 39")
        {
            redeemplayervaluehandler(39);

        }

    }

    void redeemplayervaluehandler(int i)
    {
        if (PanelManager.instance.cityblockhandler[i] == true && mortgage.mortgageinstance.Ismortgage[i] == true)
        {
            mortgage.mortgageinstance.Ismortgage[i] = false;
            if (DiceManager.Diceinstance.playerturn == 1 && PanelManager.instance.buyedby[i] == 1)
            {
                PanelManager.instance.player1M -= redeemvalue[i];
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 2 && PanelManager.instance.buyedby[i] == 2)
            {
                PanelManager.instance.player2M -= redeemvalue[i];
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 3 && PanelManager.instance.buyedby[i] == 3)
            {
                PanelManager.instance.player3M -= redeemvalue[i];
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 4 && PanelManager.instance.buyedby[i] == 4)
            {
                PanelManager.instance.player4M -= redeemvalue[i];
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
            }
            
        }
    }

    public void closeredeempanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        redeembuttonclicked = false;
        redeempanel.transform.gameObject.SetActive(false);
    }
}
