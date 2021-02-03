using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;

    // variables for money handling
    [HideInInspector]
    public Text player1money, player2money, player3money, player4money;
    [HideInInspector]
    public float player1M, player2M, player3M, player4M;


    public GameObject[] playerSymbol;
    
    public GameObject panelimage;


    [SerializeField]
    private GameObject[] image;

    [SerializeField]
    private GameObject text1;

    [SerializeField]
    private GameObject bgSale;

    int maincounter;

    [HideInInspector]
    public bool[] cityblockhandler = new bool[42];

    //[HideInInspector]
    public int[] buyedby = new int[42];

    //[HideInInspector]
    public int[] buyValue = new int[42];

    int freeparking = 0;

    int g;

   // [HideInInspector]
    public int[] citylistofplayer1 = new int[41];
   // [HideInInspector]
    public int[] citylistofplayer2 = new int[41];
   // [HideInInspector]
    public int[] citylistofplayer3 = new int[41];
   // [HideInInspector]
    public int[] citylistofplayer4 = new int[41];

    
    [HideInInspector]
    public float player1counter ;
    [HideInInspector]
    public float player2counter ;
    [HideInInspector]
    public float player3counter ;
    [HideInInspector]
    public float player4counter ;

    //[HideInInspector]
    //public int a = 1, b = 1, c = 1, d = 1;
    private void Awake()
    {
      
        image[0] = GameObject.Find(Tags.IMAGE);
        image[0].SetActive(false);

        image[1] = GameObject.Find("Image (1)");
        image[1].SetActive(false);

        image[2] = GameObject.Find("Image (2)");
        image[2].SetActive(false);

        image[3] = GameObject.Find("Image (3)");
        image[3].SetActive(false);

        image[4] = GameObject.Find("Image (4)");
        image[4].SetActive(false);

        image[5] = GameObject.Find("Image (5)");
        image[5].SetActive(false);

        image[6] = GameObject.Find("Image (6)");
        image[6].SetActive(false);

        image[7] = GameObject.Find("Image (7)");
        image[7].SetActive(false);

        image[8] = GameObject.Find("Image (8)");
        image[8].SetActive(false);

        image[9] = GameObject.Find("Image (9)");
        image[9].SetActive(false);

        image[10] = GameObject.Find("Image (10)");
        image[10].SetActive(false);

        image[11] = GameObject.Find("Image (11)");
        image[11].SetActive(false);

        image[12] = GameObject.Find("Image (12)");
        image[12].SetActive(false);

        image[13] = GameObject.Find("Image (13)");
        image[13].SetActive(false);

        image[14] = GameObject.Find("Image (14)");
        image[14].SetActive(false);

        image[15] = GameObject.Find("Image (15)");
        image[15].SetActive(false);

        image[16] = GameObject.Find("Image (16)");
        image[16].SetActive(false);

        image[17] = GameObject.Find("Image (17)");
        image[17].SetActive(false);

        image[18] = GameObject.Find("Image (18)");
        image[18].SetActive(false);

        image[19] = GameObject.Find("Image (19)");
        image[19].SetActive(false);

        image[20] = GameObject.Find("Image (20)");
        image[20].SetActive(false);

        image[21] = GameObject.Find("Image (21)");
        image[21].SetActive(false);

        image[22] = GameObject.Find("Image (22)");
        image[22].SetActive(false);

        image[23] = GameObject.Find("Image (23)");
        image[23].SetActive(false);

        image[24] = GameObject.Find("Image (24)");
        image[24].SetActive(false);

        image[25] = GameObject.Find("Image (25)");
        image[25].SetActive(false);

        image[26] = GameObject.Find("Image (26)");
        image[26].SetActive(false);

        image[27] = GameObject.Find("Image (27)");
        image[27].SetActive(false);

        image[28] = GameObject.Find("Image (28)");
        image[28].SetActive(false);

        image[29] = GameObject.Find("Image (29)");
        image[29].SetActive(false);

        image[30] = GameObject.Find("Image (30)");
        image[30].SetActive(false);

        image[31] = GameObject.Find("Image (31)");
        image[31].SetActive(false);

        image[32] = GameObject.Find("Image (32)");
        image[32].SetActive(false);

        image[33] = GameObject.Find("Image (33)");
        image[33].SetActive(false);

        image[34] = GameObject.Find("Image (34)");
        image[34].SetActive(false);

        image[35] = GameObject.Find("Image (35)");
        image[35].SetActive(false);

        image[36] = GameObject.Find("Image (36)");
        image[36].SetActive(false);

        image[37] = GameObject.Find("Image (37)");
        image[37].SetActive(false);

        image[38] = GameObject.Find("Image (38)");
        image[38].SetActive(false);

        image[39] = GameObject.Find("Image (39)");
        image[39].SetActive(false);

        image[40] = GameObject.Find("Image (40)");
        image[40].SetActive(false);



        text1 = GameObject.Find("Textsale");
        text1.SetActive(false);

        bgSale = GameObject.Find("sale background");
        bgSale.SetActive(false);

        panelimage.transform.gameObject.SetActive(false);

        // It helps to represent money with player panel on ui
        player1money = GameObject.Find("player 1 Money").GetComponent<Text>();
        player2money = GameObject.Find("player 2 Money").GetComponent<Text>();

       
            if (PlayerSelection.instance.player == 3)
            {
                player3money = GameObject.Find("player 3 Money").GetComponent<Text>();
            }
            if (PlayerSelection.instance.player == 4)
            {
                player3money = GameObject.Find("player 3 Money").GetComponent<Text>();
                player4money = GameObject.Find("player 4 Money").GetComponent<Text>();
            }
        
       

        //for( g = 1 ; g < cityblockhandler.Length; g++)
        //{
        //    cityblockhandler[g] = false;
        //}

        //cityblockhandler[40] = false;

        buyValue[1] = 60;
        buyValue[3] = 60;
        buyValue[5] = 200;
        buyValue[6] = 100;
        buyValue[8] = 100;
        buyValue[9] = 120;
        buyValue[11] = 140;
        buyValue[12] = 150;
        buyValue[13] = 140;
        buyValue[14] = 160;
        buyValue[15] = 200;
        buyValue[16] = 180;
        buyValue[18] = 180;
        buyValue[19] = 200;
        buyValue[21] = 220;
        buyValue[23] = 220;
        buyValue[24] = 240;
        buyValue[25] = 200;
        buyValue[26] = 260;
        buyValue[27] = 260;
        buyValue[28] = 150;
        buyValue[29] = 280;
        buyValue[31] = 300;
        buyValue[32] = 300;
        buyValue[34] = 320;
        buyValue[35] = 200;
        buyValue[37] = 350;
        buyValue[39] = 400;


        player1counter = 0;
        player2counter = 0;
        player3counter = 0;
        player4counter = 0;

    }

    
    private void Start()
    {
        makeInstance();
        if(menuscripts.menuinstance.gameisonline == false)
        {
            // intialization of money text to 2000
            player1M = ShowValue.showinstance.printvalue;
            player1money.text = player1M.ToString();


            player2M = ShowValue.showinstance.printvalue;
            player2money.text = player2M.ToString();



            if (PlayerSelection.instance.player == 3)
            {
                player3M = ShowValue.showinstance.printvalue;
                player3money.text = player3M.ToString();
            }
            if (PlayerSelection.instance.player == 4)
            {
                player3M = ShowValue.showinstance.printvalue;
                player3money.text = player3M.ToString();
                player4M = ShowValue.showinstance.printvalue;
                player4money.text = player4M.ToString();
            }



        }


    }


   
    void makeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void ShowpanelImage(int i)
    {
        maincounter = i;

        if (cityblockhandler[maincounter] == false)
        {
            panelimage.transform.gameObject.SetActive(true);
            bgSale.SetActive(true);
            image[i].SetActive(true);
            text1.SetActive(true);

            if(i == 10)
            {
                image[i].SetActive(false);
                bgSale.SetActive(false);
                panelimage.transform.gameObject.SetActive(false);
            }
            // to close the bg of the chance and community panel
            if (i == 2||i == 7 || i == 17 || i == 22 || i == 33 || i == 36 || i == 4 || i == 38 || i == 20 || i == 40)
            {
                bgSale.SetActive(false);
            }

            // it is used to close the panel which reqiured some time for closing
            if (i == 4 || i == 38 || i == 20 || i == 30 || i == 40 || i == 2 || i == 7 || i == 17 || i == 22 || i == 33 || i == 36)
            {
                text1.SetActive(false);
                StartCoroutine(waitforsec(i));
            }
        }

        //jail block
        //if (maincounter == 30)
        //{
        //    PlayerToken.playerinstance.jailfunction();
        //}

        // community chest block
        if (maincounter == 2 || maincounter == 17 || maincounter == 33)
        {
            CommunityChest.communityinstance.communitychestfunction();
        }



        // chance block
        if (maincounter == 7 || maincounter == 22 || maincounter == 36)
        {
            ChancesScripts.chanceinstance.chanceFunction();
        }

        
        //free parking
        if(maincounter == 20)
        {
            if(DiceManager.Diceinstance.playerturn == 1)
            {
                player1M = player1M + freeparking;
                player1money.text = player1M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                player2M = player2M + freeparking;
                player2money.text = player2M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                player3M = player3M + freeparking;
                player3money.text = player3M.ToString();
            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                player4M = player4M + freeparking;
                player4money.text = player4M.ToString();
            }
            freeparking = 0;

        }



        // income tax
        if (maincounter == 4)
        {
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                if (player1M > 200)
                {
                    player1M = player1M - 200;
                    player1money.text = player1M.ToString();
                    freeparking += 200;

                }
                else
                {
                    print("you do not have the money");
                }
            }

            if (DiceManager.Diceinstance.playerturn == 2)
            {
                if (player2M > 200)
                {
                    player2M = player2M - 200;
                    player2money.text = player2M.ToString();
                    freeparking += 200;

                }
                else
                {
                    print("you do not have the money");
                }
            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                if (player3M > 200)
                {
                    player3M = player3M - 200;
                    player3money.text = player3M.ToString();
                    freeparking += 200;
                }
                else
                {
                    print("you do not have the money");
                }
            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                if (player4M > 200)
                {
                    player4M = player4M - 200;
                    player4money.text = player4M.ToString();
                    freeparking += 200;
                }
                else
                {
                    print("you do not have the money");
                }
            }
        }
        // luxury tax
        if (maincounter == 38)
        {
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                if (player1M > 100)
                {
                    player1M = player1M - 100;
                    player1money.text = player1M.ToString();
                    freeparking += 100;
                }
                else
                {
                    print("you do not have the money");
                }
            }

            if (DiceManager.Diceinstance.playerturn == 2)
            {
                if (player2M > 100)
                {
                    player2M = player2M - 100;
                    player2money.text = player2M.ToString();
                    freeparking += 100;
                }
                else
                {
                    print("you do not have the money");
                }
            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                if (player3M > 100)
                {
                    player3M = player3M - 100;
                    player3money.text = player3M.ToString();
                    freeparking += 100;
                }
                else
                {
                    print("you do not have the money");
                }
            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                if (player4M > 100)
                {
                    player4M = player4M - 100;
                    player4money.text = player4M.ToString();
                    freeparking += 100;
                }
                else
                {
                    print("you do not have the money");
                }
            }
           
        }

    }


    public void AuctionButton()
    {
        text1.SetActive(false);
        image[maincounter].SetActive(false);
        bgSale.SetActive(false);
        panelimage.transform.gameObject.SetActive(false);

        //print("auction is done");
        AuctionManager.instance2.ShowAuctionpanelImage(maincounter);

    }



    IEnumerator waitforsec(int j)
    {
        yield return new WaitForSeconds(4f);
        image[j].SetActive(false);
        bgSale.SetActive(false);
        panelimage.transform.gameObject.SetActive(false);


    }

    public void BuyButton()
    {
       // PlayerToken.playerinstance.playersymbol(maincounter);
       // print("value of sra " + maincounter);
        text1.SetActive(false);
        image[maincounter].SetActive(false);
        bgSale.SetActive(false);
        panelimage.transform.gameObject.SetActive(false);

        // calculation of buying city with differnt players
        if (DiceManager.Diceinstance.playerturn == 1 && cityblockhandler[maincounter] == false)
        {
            if (player1M > buyValue[maincounter])
            {
                
                cityblockhandler[maincounter] = true;  // it is used to tell that the perticular city is yet buyed or not
                player1M = player1M - buyValue[maincounter];
                player1money.text = player1M.ToString();
                buyedby[maincounter] = 1; // tell us which player will get the city
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                if( menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.playersymbol(maincounter);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.playersymbol(maincounter);
                }
               
                citylistofplayer1[maincounter] = maincounter;
                player1counter += 1;
              

            }
            else
            {
                print("you do not have the money");
            }

        }
        if (DiceManager.Diceinstance.playerturn == 2 && cityblockhandler[maincounter] == false)
        {
            if (player2M > buyValue[maincounter])
            {
                
                cityblockhandler[maincounter] = true;
                player2M = player2M - buyValue[maincounter];
                player2money.text = player2M.ToString();
                buyedby[maincounter] = 2;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                if (menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.playersymbol(maincounter);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.playersymbol(maincounter);
                }
                citylistofplayer2[maincounter] = maincounter;
                player2counter += 1;

              
            }
            else
            {
                print("you do not have the money");
            }

        }
        if (DiceManager.Diceinstance.playerturn == 3 && cityblockhandler[maincounter] == false)
        {
            if (player3M > buyValue[maincounter])
            {
                
                cityblockhandler[maincounter] = true;
                player3M = player3M - buyValue[maincounter];
                player3money.text = player3M.ToString();
                buyedby[maincounter] = 3;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                if (menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.playersymbol(maincounter);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.playersymbol(maincounter);
                }
                
                citylistofplayer3[maincounter] = maincounter;
                player3counter += 1;
               
            }
            else
            {
                print("you do not have the money");
            }

        }
        if (DiceManager.Diceinstance.playerturn == 4 && cityblockhandler[maincounter] == false)
        {
            if (player4M > buyValue[maincounter])
            {
                
                cityblockhandler[maincounter] = true;
                player4M = player4M - buyValue[maincounter];
                player4money.text = player4M.ToString();
                buyedby[maincounter] = 4;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                if (menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.playersymbol(maincounter);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.playersymbol(maincounter);
                }
                
                citylistofplayer4[maincounter] = maincounter;
                player4counter += 1;
              
            }
            else
            {
                print("you do not have the money");
            }

        }

    }


    public void auctionbuyied(int playernumber)
    {


        if (playernumber == 1 && cityblockhandler[maincounter] == false)
        {
            if (player1M > buyValue[maincounter])
            {

                cityblockhandler[maincounter] = true;  // it is used to tell that the perticular city is yet buyed or not
                player1M = player1M - buyValue[maincounter];
                player1money.text = player1M.ToString();
                buyedby[maincounter] = 1; // tell us which player will get the city
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
               
                if (menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.Auctionplayersymbol(maincounter, 1);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.Auctionplayersymbol(maincounter, 1);
                }
                citylistofplayer1[maincounter] = maincounter;
                player1counter += 1;


            }
            else
            {
                print("you do not have the money");
            }

        }
        if (playernumber == 2 && cityblockhandler[maincounter] == false)
        {
            if (player2M > buyValue[maincounter])
            {

                cityblockhandler[maincounter] = true;
                player2M = player2M - buyValue[maincounter];
                player2money.text = player2M.ToString();
                buyedby[maincounter] = 2;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                if (menuscripts.menuinstance.gameisonline == false)
                {
                    PlayerToken.playerinstance.Auctionplayersymbol(maincounter, 2);
                }
                if (menuscripts.menuinstance.gameisonline == true)
                {
                    playerpropertyindication.playerpropertyinstance.Auctionplayersymbol(maincounter, 2);
                }
                citylistofplayer2[maincounter] = maincounter;
                player2counter += 1;


            }
            else
            {
                print("you do not have the money");
            }

        }
        if (playernumber == 3 && cityblockhandler[maincounter] == false)
        {
            if (player3M > buyValue[maincounter])
            {

                cityblockhandler[maincounter] = true;
                player3M = player3M - buyValue[maincounter];
                player3money.text = player3M.ToString();
                buyedby[maincounter] = 3;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                PlayerToken.playerinstance.Auctionplayersymbol(maincounter, 3);
                citylistofplayer3[maincounter] = maincounter;
                player3counter += 1;

            }
            else
            {
                print("you do not have the money");
            }

        }
        if (playernumber == 4 && cityblockhandler[maincounter] == false)
        {
            if (player4M > buyValue[maincounter])
            {

                cityblockhandler[maincounter] = true;
                player4M = player4M - buyValue[maincounter];
                player4money.text = player4M.ToString();
                buyedby[maincounter] = 4;
                BuyPanel.instance1.ShowBuypanelImage(maincounter);
                PlayerToken.playerinstance.Auctionplayersymbol(maincounter, 4);
                citylistofplayer4[maincounter] = maincounter;
                player4counter += 1;

            }
            else
            {
                print("you do not have the money");
            }

        }
    }





}
