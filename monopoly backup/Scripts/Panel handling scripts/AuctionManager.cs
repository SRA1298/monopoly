using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuctionManager : MonoBehaviour
{

    public static AuctionManager instance2;

    public GameObject Auctionpanel;

    [SerializeField]
    private GameObject[] AuctionImage;

    [SerializeField]
    private GameObject AuctionText;

    [SerializeField]
    private GameObject AuctionBG;
    [HideInInspector]
    public Text auctionmoneyrepresent;
    [HideInInspector]
    public float auctionmoney;

    public GameObject auctionpasspanel;

    public float moneyholder;
    public GameObject player1to2;
    public GameObject player2to3;
    public GameObject player3to4;
    public GameObject player4to1;
    public GameObject player3to1;
    public GameObject player2to1;

    bool player1to2check;
    bool player2to3check;
    bool player3to4check;
    bool player4to1check;
    bool player3to1check;
    bool player2to1check;
    bool fold1;
    bool fold2;
    bool fold3;
    bool fold4;

    public GameObject bidbutton;
    public GameObject slider;
    private void Awake()
    {

        AuctionImage[0] = GameObject.Find("Auction Image");
        AuctionImage[0].SetActive(false);

        AuctionImage[1] = GameObject.Find("Auction Image (1)");
        AuctionImage[1].SetActive(false);

        AuctionImage[2] = GameObject.Find("Auction Image (2)");
        AuctionImage[2].SetActive(false);

        AuctionImage[3] = GameObject.Find("Auction Image (3)");
        AuctionImage[3].SetActive(false);

        AuctionImage[4] = GameObject.Find("Auction Image (4)");
        AuctionImage[4].SetActive(false);

        AuctionImage[5] = GameObject.Find("Auction Image (5)");
        AuctionImage[5].SetActive(false);

        AuctionImage[6] = GameObject.Find("Auction Image (6)");
        AuctionImage[6].SetActive(false);

        AuctionImage[7] = GameObject.Find("Auction Image (7)");
        AuctionImage[7].SetActive(false);

        AuctionImage[8] = GameObject.Find("Auction Image (8)");
        AuctionImage[8].SetActive(false);

        AuctionImage[9] = GameObject.Find("Auction Image (9)");
        AuctionImage[9].SetActive(false);

        AuctionImage[10] = GameObject.Find("Auction Image (10)");
        AuctionImage[10].SetActive(false);

        AuctionImage[11] = GameObject.Find("Auction Image (11)");
        AuctionImage[11].SetActive(false);

        AuctionImage[12] = GameObject.Find("Auction Image (12)");
        AuctionImage[12].SetActive(false);

        AuctionImage[13] = GameObject.Find("Auction Image (13)");
        AuctionImage[13].SetActive(false);

        AuctionImage[14] = GameObject.Find("Auction Image (14)");
        AuctionImage[14].SetActive(false);

        AuctionImage[15] = GameObject.Find("Auction Image (15)");
        AuctionImage[15].SetActive(false);

        AuctionImage[16] = GameObject.Find("Auction Image (16)");
        AuctionImage[16].SetActive(false);

        AuctionImage[17] = GameObject.Find("Auction Image (17)");
        AuctionImage[17].SetActive(false);

        AuctionImage[18] = GameObject.Find("Auction Image (18)");
        AuctionImage[18].SetActive(false);

        AuctionImage[19] = GameObject.Find("Auction Image (19)");
        AuctionImage[19].SetActive(false);

        AuctionImage[20] = GameObject.Find("Auction Image (20)");
        AuctionImage[20].SetActive(false);

        AuctionImage[21] = GameObject.Find("Auction Image (21)");
        AuctionImage[21].SetActive(false);

        AuctionImage[22] = GameObject.Find("Auction Image (22)");
        AuctionImage[22].SetActive(false);

        AuctionImage[23] = GameObject.Find("Auction Image (23)");
        AuctionImage[23].SetActive(false);

        AuctionImage[24] = GameObject.Find("Auction Image (24)");
        AuctionImage[24].SetActive(false);

        AuctionImage[25] = GameObject.Find("Auction Image (25)");
        AuctionImage[25].SetActive(false);

        AuctionImage[26] = GameObject.Find("Auction Image (26)");
        AuctionImage[26].SetActive(false);

        AuctionImage[27] = GameObject.Find("Auction Image (27)");
        AuctionImage[27].SetActive(false);

        AuctionImage[28] = GameObject.Find("Auction Image (28)");
        AuctionImage[28].SetActive(false);

        AuctionImage[29] = GameObject.Find("Auction Image (29)");
        AuctionImage[29].SetActive(false);

        AuctionImage[30] = GameObject.Find("Auction Image (30)");
        AuctionImage[30].SetActive(false);

        AuctionImage[31] = GameObject.Find("Auction Image (31)");
        AuctionImage[31].SetActive(false);

        AuctionImage[32] = GameObject.Find("Auction Image (32)");
        AuctionImage[32].SetActive(false);

        AuctionImage[33] = GameObject.Find("Auction Image (33)");
        AuctionImage[33].SetActive(false);

        AuctionImage[34] = GameObject.Find("Auction Image (34)");
        AuctionImage[34].SetActive(false);

        AuctionImage[35] = GameObject.Find("Auction Image (35)");
        AuctionImage[35].SetActive(false);

        AuctionImage[36] = GameObject.Find("Auction Image (36)");
        AuctionImage[36].SetActive(false);

        AuctionImage[37] = GameObject.Find("Auction Image (37)");
        AuctionImage[37].SetActive(false);

        AuctionImage[38] = GameObject.Find("Auction Image (38)");
        AuctionImage[38].SetActive(false);

        AuctionImage[39] = GameObject.Find("Auction Image (39)");
        AuctionImage[39].SetActive(false);

        AuctionImage[40] = GameObject.Find("Auction Image (40)");
        AuctionImage[40].SetActive(false);

        fold1 = false;
        fold2 = false;
        fold3 = false;
        fold4 = false;

        AuctionText = GameObject.Find("AuctionText");
        AuctionText.SetActive(false);

        AuctionBG = GameObject.Find("Auction background");
        AuctionBG.SetActive(false);

        Auctionpanel.transform.gameObject.SetActive(false);

        auctionmoneyrepresent = GameObject.Find("auction money change").GetComponent<Text>();
        auctionmoneyrepresent.transform.gameObject.SetActive(false);

        player1to2.transform.gameObject.SetActive(false);
        player2to3.transform.gameObject.SetActive(false);
        player3to4.transform.gameObject.SetActive(false);
        player4to1.transform.gameObject.SetActive(false);
        player3to1.transform.gameObject.SetActive(false);
        player2to1.transform.gameObject.SetActive(false);

        auctionpasspanel.transform.gameObject.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        makeInstance2();

    }

    void makeInstance2()
    {
        if (instance2 == null)
        {
            instance2 = this;
        }
    }


    public void BidButton()
    {
        bidbutton.transform.gameObject.SetActive(true);
        slider.transform.gameObject.SetActive(true);
        if (auctionmoney >= moneyholder)
        {
            moneyholder = auctionmoney;
        }
        print("Bid button pressed");
        if (PlayerSelection.instance.player == 4)
        {
            if (player1to2check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
            }
            if (player2to3check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to3.transform.gameObject.SetActive(true);
                player2to3check = false;
            }
            if (player3to4check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player3to4.transform.gameObject.SetActive(true);
                player3to4check = false;
            }
            if (player4to1check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player4to1.transform.gameObject.SetActive(true);
                player4to1check = false;
            }

        }

        if (PlayerSelection.instance.player == 3)
        {
            if (player1to2check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
            }
            if (player2to3check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to3.transform.gameObject.SetActive(true);
                player2to3check = false;
            }
            if (player3to1check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player3to1.transform.gameObject.SetActive(true);
                player3to1check = false;
            }


        }

        if (PlayerSelection.instance.player == 2)
        {
            if (player1to2check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
            }
            if (player2to1check == true)
            {
                moneyholder += 1;
                auctionmoneyrepresent.text = " Rs " + moneyholder.ToString();
                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to1.transform.gameObject.SetActive(true);
                player2to1check = false;
            }


        }



    }

    public void FoldButton()
    {
        bidbutton.transform.gameObject.SetActive(true);
        slider.transform.gameObject.SetActive(true);
        print("fold button pressed");
        // when 4 players are there
        if (PlayerSelection.instance.player == 4)
        {


            if (player1to2check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
                fold1 = true;
            }
            if (player2to3check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to3.transform.gameObject.SetActive(true);
                player2to3check = false;
                fold2 = true;
            }
            if (player3to4check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player3to4.transform.gameObject.SetActive(true);
                player3to4check = false;
                fold3 = true;
            }
            if (player4to1check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player4to1.transform.gameObject.SetActive(true);
                player4to1check = false;
                fold4 = true;
            }
            // for owning the property
            if (fold1 == true && fold2 == true && fold3 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(4);


            }
            if (fold1 == true && fold2 == true && fold4 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(3);

            }
            if (fold1 == true && fold3 == true && fold4 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(2);

            }
            if (fold2 == true && fold3 == true && fold4 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(1);

            }

        }
        // when 3 player are there
        if (PlayerSelection.instance.player == 3)
        {


            if (player1to2check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
                fold1 = true;
            }
            if (player2to3check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to3.transform.gameObject.SetActive(true);
                player2to3check = false;
                fold2 = true;
            }
            if (player3to1check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player3to1.transform.gameObject.SetActive(true);
                player3to1check = false;
                fold3 = true;
            }
            // for owning the property
            if (fold1 == true && fold2 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(3);

            }
            if (fold1 == true && fold3 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(2);

            }
            if (fold2 == true && fold3 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(1);

            }


        }
        // when 2 player are there
        if (PlayerSelection.instance.player == 2)
        {



            if (player1to2check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player1to2.transform.gameObject.SetActive(true);
                player1to2check = false;
                fold1 = true;
            }
            if (player2to1check == true)
            {

                auctionpasspanel.transform.gameObject.SetActive(true);
                player2to1.transform.gameObject.SetActive(true);
                player2to1check = false;
                fold2 = true;
            }
            // for owing the property
            if (fold1 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(2);

            }
            if (fold2 == true)
            {
                closethebutton();
                Auctionpanel.transform.gameObject.SetActive(false);
                auctionmoneyrepresent.transform.gameObject.SetActive(false);
                PanelManager.instance.auctionbuyied(1);

            }

        }

    }


    public void ShowAuctionpanelImage(int i)
    {
        fold1 = false;
        fold2 = false;
        fold3 = false;
        fold4 = false;
        Auctionpanel.transform.gameObject.SetActive(true);
        auctionmoneyrepresent.transform.gameObject.SetActive(true);
        AuctionBG.SetActive(true);
        AuctionText.SetActive(true);
        AuctionImage[i].SetActive(true);
        auctionmoney = 1;
        moneyholder = 0;
        auctionmoneyrepresent.text = " Rs " + auctionmoney.ToString();
        player1to2check = true;
        // StartCoroutine(waitforsecAuction(i));

    }

    IEnumerator waitforsecAuction(int j)
    {
        yield return new WaitForSeconds(4f);
        AuctionImage[j].SetActive(false);
        AuctionText.SetActive(false);
        AuctionBG.SetActive(false);
        Auctionpanel.transform.gameObject.SetActive(false);
        auctionmoneyrepresent.transform.gameObject.SetActive(false);

    }

    public void player1to2button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player1to2.transform.gameObject.SetActive(false);
        player2to3check = true;
        if (PlayerSelection.instance.player == 2)
        {
            player2to1check = true;
        }
        if (fold2 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }

    }

    public void player2to3button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player2to3.transform.gameObject.SetActive(false);
        player3to4check = true;
        if (PlayerSelection.instance.player == 3)
        {
            player3to1check = true;
        }
        if (fold3 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }
    }
    public void player3to4button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player3to4.transform.gameObject.SetActive(false);
        player4to1check = true;
        if (fold4 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }
    }
    public void player4to1button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player4to1.transform.gameObject.SetActive(false);
        player1to2check = true;
        if (fold1 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }
    }

    public void player3to1button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player3to1.transform.gameObject.SetActive(false);
        player1to2check = true;
        if (fold1 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }
    }
    public void player2to1button()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player2to1.transform.gameObject.SetActive(false);
        player1to2check = true;
        if (fold1 == true)
        {
            slider.transform.gameObject.SetActive(false);
            bidbutton.transform.gameObject.SetActive(false);
        }
    }



    public void closethebutton()
    {
        auctionpasspanel.transform.gameObject.SetActive(false);
        player1to2.transform.gameObject.SetActive(false);
        player2to3.transform.gameObject.SetActive(false);
        player3to4.transform.gameObject.SetActive(false);
        player4to1.transform.gameObject.SetActive(false);
        player3to1.transform.gameObject.SetActive(false);
        player2to1.transform.gameObject.SetActive(false);
    }


}
