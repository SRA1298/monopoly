using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBSMManager : MonoBehaviour
{
    public static TBSMManager tbmsinstance;
    public GameObject TradePanel;

    public GameObject fortradeplayer1;
    public GameObject fortradeplayer2;
    public GameObject fortradeplayer3;
    public GameObject fortradeplayer4;

    // for text to know which player city are shown
    public GameObject[] leftplayertrade;
    public GameObject[] rightplayertrade;

    public GameObject player1but3;
    public GameObject player1but4;

    public GameObject player2but3;
    public GameObject player2but4;

    public GameObject player3but4;

    public GameObject offerbutton;
    public GameObject cancelbutton;
    public GameObject acceptbutton;
    public GameObject rejectbutton;

    public GameObject passbutton;

    [HideInInspector]
    public bool p1b2;
    [HideInInspector]
    public bool p1b3;
    [HideInInspector]
    public bool p1b4;
    [HideInInspector]
    public bool p2b1;
    [HideInInspector]
    public bool p2b3;
    [HideInInspector]
    public bool p2b4;
    [HideInInspector]
    public bool p3b1;
    [HideInInspector]
    public bool p3b2;
    [HideInInspector]
    public bool p3b4;
    [HideInInspector]
    public bool p4b1;
    [HideInInspector]
    public bool p4b2;
    [HideInInspector]
    public bool p4b3;
    private void Awake()
    {
        
        fortradeplayer1.transform.gameObject.SetActive(false);
        fortradeplayer2.transform.gameObject.SetActive(false);
        fortradeplayer3.transform.gameObject.SetActive(false);
        fortradeplayer4.transform.gameObject.SetActive(false);
        passbutton.transform.gameObject.SetActive(false);
        TradePanel.transform.gameObject.SetActive(false);

        for(int i= 0; i < 5; i++)
        {
            leftplayertrade[i].transform.gameObject.SetActive(false);
        }

        for (int j = 0; j < 5; j++)
        {
            rightplayertrade[j].transform.gameObject.SetActive(false);
        }

       
        makeinstance();

    }

    void makeinstance()
    {
        if(tbmsinstance == null)
        {
            tbmsinstance = this;
        }
    }
    public void TradeOnButton()
    {
        acceptbutton.transform.gameObject.SetActive(false);
        rejectbutton.transform.gameObject.SetActive(false);
        if (DiceManager.Diceinstance.playerturn == 1)
        {
            fortradeplayer1.transform.gameObject.SetActive(true);
            if(PlayerSelection.instance.player == 3)
            {
                player1but4.transform.gameObject.SetActive(false);
            }
            if (PlayerSelection.instance.player == 2)
            {
                player1but3.transform.gameObject.SetActive(false);
                player1but4.transform.gameObject.SetActive(false);
            }

        }
        if(DiceManager.Diceinstance.playerturn == 2)
        {
            fortradeplayer2.transform.gameObject.SetActive(true);
            if (PlayerSelection.instance.player == 3)
            {
                player2but4.transform.gameObject.SetActive(false);
            }
            if (PlayerSelection.instance.player == 2)
            {
                player2but3.transform.gameObject.SetActive(false);
                player2but4.transform.gameObject.SetActive(false);
            }
        }
        if (DiceManager.Diceinstance.playerturn == 3)
        {
            fortradeplayer3.transform.gameObject.SetActive(true);
            if (PlayerSelection.instance.player == 3)
            {
                player3but4.transform.gameObject.SetActive(false);
            }
        }
        if (DiceManager.Diceinstance.playerturn == 4)
        {
            fortradeplayer4.transform.gameObject.SetActive(true);
        }
        racastdebugging.rayinstance.clickcityrepresentation = false;   // this is used to stop the city panel representation on click
        StartCoroutine("waitforsec");
    }

    // for player 1
    public void player1button2()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[1].transform.gameObject.SetActive(true);
        rightplayertrade[2].transform.gameObject.SetActive(true);

        // this function is used to display player cities on trading panel
        tradingfunctionality.tradinginstance.tradingpanelfunctionp1b2();
        p1b2 = true;



    }

    public void player1button3()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[1].transform.gameObject.SetActive(true);
        rightplayertrade[3].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp1b3();
        p1b3 = true;
    }

    public void player1button4()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[1].transform.gameObject.SetActive(true);
        rightplayertrade[4].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp1b4();
        p1b4 = true;
    }

    // for player 2
    public void player2button1()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[2].transform.gameObject.SetActive(true);
        rightplayertrade[1].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp2b1();
        p2b1 = true;
    }

    public void player2button3()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[2].transform.gameObject.SetActive(true);
        rightplayertrade[3].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp2b3();
        p2b3 = true;
    }

    public void player2button4()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[2].transform.gameObject.SetActive(true);
        rightplayertrade[4].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp2b4();
        p2b4 = true;
    }

    public void player3button1()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[3].transform.gameObject.SetActive(true);
        rightplayertrade[1].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp3b1();
        p3b1 = true;
    }

    public void player3button2()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[3].transform.gameObject.SetActive(true);
        rightplayertrade[2].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp3b2();
        p3b2 = true;
    }
    public void player3button4()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[3].transform.gameObject.SetActive(true);
        rightplayertrade[4].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp3b4();
        p3b4 = true;
    }
    public void player4button1()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[4].transform.gameObject.SetActive(true);
        rightplayertrade[1].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp4b1();
        p4b1 = true;
    }

    public void player4button2()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[4].transform.gameObject.SetActive(true);
        rightplayertrade[2].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp4b2();
        p4b2 = true;
    }
    public void player4button3()
    {
        TradePanel.transform.gameObject.SetActive(true);
        leftplayertrade[4].transform.gameObject.SetActive(true);
        rightplayertrade[3].transform.gameObject.SetActive(true);

        tradingfunctionality.tradinginstance.tradingpanelfunctionp4b3();
        p4b3 = true;
    }


    public void BuildButton()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // this is used to stop the city panel representation on click
        Buyhouse.buyhouseinstance.clickedbuyhouse = true;
        Buyhouse.buyhouseinstance.buyhousepanel.transform.gameObject.SetActive(true);
    }

    public void SellButton()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;   // this is used to stop the city panel representation on click
        sellhouse.sellhouseinstance.clickedsellhouse = true;
        sellhouse.sellhouseinstance.sellhousepanel.transform.gameObject.SetActive(true);

    }

    public void MortgageButton()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false; // this is used to stop the city panel representation on click
        mortgage.mortgageinstance.mortgagebuttonclicked = true;
        mortgage.mortgageinstance.mortgagepanel.transform.gameObject.SetActive(true);
       
    }
    public void RedeemButton()
    {
        racastdebugging.rayinstance.clickcityrepresentation = false;   // this is used to stop the city panel representation on click
        redeemscripts.redeeminstance.redeembuttonclicked = true;
        redeemscripts.redeeminstance.redeempanel.transform.gameObject.SetActive(true);
    }

    public void OfferButton()
    {
        print("offer button is pressed");

        for (int i = 0; i < tradingfunctionality.tradinginstance.leftplayercity.Length; i++)
        {
            tradingfunctionality.tradinginstance.leftplayercity[i].transform.gameObject.SetActive(false);
        }

        for (int i = 0; i < tradingfunctionality.tradinginstance.rightplayercity.Length; i++)
        {
            tradingfunctionality.tradinginstance.rightplayercity[i].transform.gameObject.SetActive(false);
        }

        TradePanel.transform.gameObject.SetActive(false);
        passbutton.transform.gameObject.SetActive(true);



    }
    public void CancelButton()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        TradePanel.transform.gameObject.SetActive(false);

        for (int i = 0; i < 5; i++)
        {
            leftplayertrade[i].transform.gameObject.SetActive(false);
        }

        for (int j = 0; j < 5; j++)
        {
            rightplayertrade[j].transform.gameObject.SetActive(false);
        }

        for (int i = 0; i < tradingfunctionality.tradinginstance.leftplayercity.Length; i++)
        {
            tradingfunctionality.tradinginstance.leftplayercity[i].transform.gameObject.SetActive(false);
        }

        for (int i = 0; i < tradingfunctionality.tradinginstance.rightplayercity.Length; i++)
        {
            tradingfunctionality.tradinginstance.rightplayercity[i].transform.gameObject.SetActive(false);
        }

    }


    IEnumerator waitforsec()
    {
        
        yield return new WaitForSeconds(3f);

        fortradeplayer1.transform.gameObject.SetActive(false);
        fortradeplayer2.transform.gameObject.SetActive(false);
        fortradeplayer3.transform.gameObject.SetActive(false);
        fortradeplayer4.transform.gameObject.SetActive(false);

    }

    public void passbuttonfunction()
    {
        passbutton.transform.gameObject.SetActive(false);
        TradePanel.transform.gameObject.SetActive(true);

        offerbutton.transform.gameObject.SetActive(false);
        cancelbutton.transform.gameObject.SetActive(false);
        acceptbutton.transform.gameObject.SetActive(true);
        rejectbutton.transform.gameObject.SetActive(true);

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.leftplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.rightplayercity[j].transform.gameObject.SetActive(true);
                }
            }
        }
    }
}
