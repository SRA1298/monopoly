using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RentFunctionality : MonoBehaviour
{

    public static RentFunctionality Rentinstance;
    
    int maincounterrent;

    [HideInInspector]
    public int[] RentValue = new int[42];

    public GameObject RentPanel;

    [HideInInspector]
    public Text indiviualRent;
    [HideInInspector]
    public float indiviualRentValue;

    public GameObject[] RentImage;

    public int[] house1rent = new int[41];
    public int[] house2rent = new int[41];
    public int[] house3rent = new int[41];
    public int[] house4rent = new int[41];
    public int[] hotelrent = new int[41];

   


    void Awake()
    {
        RentValue[1] = 5;
        RentValue[3] = 10;
        RentValue[5] = 25;
        RentValue[6] = 10;
        RentValue[8] = 10;
        RentValue[9] = 15;
        RentValue[11] = 15;
        RentValue[12] = 15;
        RentValue[13] = 20;
        RentValue[14] = 20;
        RentValue[15] = 25;
        RentValue[16] = 20;
        RentValue[18] = 20;
        RentValue[19] = 30;
        RentValue[21] = 30;
        RentValue[23] = 30;
        RentValue[24] = 40;
        RentValue[25] = 25;
        RentValue[26] = 40;
        RentValue[27] = 40;
        RentValue[28] = 40;
        RentValue[29] = 50;
        RentValue[31] = 50;
        RentValue[32] = 50;
        RentValue[34] = 60;
        RentValue[35] = 25;
        RentValue[37] = 70;
        RentValue[39] = 80;



        // this is used for the multiplayer rent functionality
        RentImage[0] = GameObject.Find("2 => 1");
        RentImage[0].SetActive(false);

        RentImage[1] = GameObject.Find("3 = > 1");
        RentImage[1].SetActive(false);

        RentImage[2] = GameObject.Find("4 => 1");
        RentImage[2].SetActive(false);

        RentImage[3] = GameObject.Find("1 => 2");
        RentImage[3].SetActive(false);

        RentImage[4] = GameObject.Find("3 => 2");
        RentImage[4].SetActive(false);

        RentImage[5] = GameObject.Find("4 => 2");
        RentImage[5].SetActive(false);

        RentImage[6] = GameObject.Find("1 => 3");
        RentImage[6].SetActive(false);

        RentImage[7] = GameObject.Find("2 => 3");
        RentImage[7].SetActive(false);

        RentImage[8] = GameObject.Find("4 => 3");
        RentImage[8].SetActive(false);

        RentImage[9] = GameObject.Find("1 => 4");
        RentImage[9].SetActive(false);

        RentImage[10] = GameObject.Find("2 => 4");
        RentImage[10].SetActive(false);

        RentImage[11] = GameObject.Find("3 => 4");
        RentImage[11].SetActive(false);

        RentPanel.transform.gameObject.SetActive(false);

        indiviualRent = GameObject.Find("rent money").GetComponent<Text>();
        indiviualRent.transform.gameObject.SetActive(false);
     
    }



    private void Start()
    {
        makeinstance();

    }
    
    void makeinstance()
    {
        if(Rentinstance == null)
        {
            Rentinstance = this;
        }
    }


    public void RentFunction(int i)
    {
        maincounterrent = i;

        if(PanelManager.instance.cityblockhandler[maincounterrent] == true && mortgage.mortgageinstance.Ismortgage[maincounterrent] == false && (maincounterrent == 12 || maincounterrent == 28))
        {
            RentPanel.transform.gameObject.SetActive(true);
            indiviualRent.transform.gameObject.SetActive(true);
            if (PanelManager.instance.buyedby[maincounterrent] == 1)
            {
                if (DiceManager.Diceinstance.playerturn == 1)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }

                if (DiceManager.Diceinstance.playerturn == 2)
                {
                    PanelManager.instance.player2M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player1M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[0].SetActive(true);


                }
                if (DiceManager.Diceinstance.playerturn == 3)
                {
                    PanelManager.instance.player3M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player1M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[1].SetActive(true);


                }
                if (DiceManager.Diceinstance.playerturn == 4)
                {
                    PanelManager.instance.player4M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                    PanelManager.instance.player1M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[2].SetActive(true);

                }
            }

            if(PanelManager.instance.buyedby[maincounterrent] == 2)
            {
                if (DiceManager.Diceinstance.playerturn == 2)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                if (DiceManager.Diceinstance.playerturn == 1)
                {
                    PanelManager.instance.player1M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[3].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 3)
                {
                    PanelManager.instance.player3M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player2M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[4].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 4)
                {
                    PanelManager.instance.player4M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                    PanelManager.instance.player2M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[5].SetActive(true);

                }
            }
            if(PanelManager.instance.buyedby[maincounterrent] == 3)
            {
                if (DiceManager.Diceinstance.playerturn == 3)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                if (DiceManager.Diceinstance.playerturn == 1)
                {
                    PanelManager.instance.player1M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player3M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[6].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 2)
                {
                    PanelManager.instance.player2M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[7].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 4)
                {
                    PanelManager.instance.player4M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                    PanelManager.instance.player3M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[8].SetActive(true);

                }
            }
            if(PanelManager.instance.buyedby[maincounterrent] == 4)
            {
                if (DiceManager.Diceinstance.playerturn == 4)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                if (DiceManager.Diceinstance.playerturn == 1)
                {
                    PanelManager.instance.player1M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player4M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[9].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 2)
                {
                    PanelManager.instance.player2M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player4M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[10].SetActive(true);

                }
                if (DiceManager.Diceinstance.playerturn == 3)
                {
                    PanelManager.instance.player3M -= PlayerToken.playerinstance.companyrent;
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4M += PlayerToken.playerinstance.companyrent;

                    indiviualRentValue = PlayerToken.playerinstance.companyrent;
                    indiviualRent.text = indiviualRentValue.ToString();
                    RentImage[11].SetActive(true);

                }
            }
        }




        // this if statement contains condition which helps to tell when we need rent functionlity
        if (PanelManager.instance.cityblockhandler[maincounterrent] == true && mortgage.mortgageinstance.Ismortgage[maincounterrent] == false && (maincounterrent != 12 || maincounterrent != 28))
        {
            RentPanel.transform.gameObject.SetActive(true);
            indiviualRent.transform.gameObject.SetActive(true);

            /* when property is of first player */
            if (PanelManager.instance.buyedby[maincounterrent] == 1)
            {
                if(DiceManager.Diceinstance.playerturn == 1)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                // no house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 0)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= RentValue[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= RentValue[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= RentValue[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }
                // one house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 1)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house1rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house1rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house1rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }
                // two house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 2)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house2rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house2rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house2rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }
                //three house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 3)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house3rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house3rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house3rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }
                // four house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 4)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house4rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house4rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house4rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }
                // for hotel
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 5)
                {

                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= hotelrent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[0].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= hotelrent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[1].SetActive(true);


                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= hotelrent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[2].SetActive(true);

                    }
                }


                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                StartCoroutine("waittoshowrent");
            }
            /*     when property is of second player               */
            if (PanelManager.instance.buyedby[maincounterrent] == 2)
            {
                if (DiceManager.Diceinstance.playerturn == 2)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                // no house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 0)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= RentValue[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= RentValue[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= RentValue[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }
                // one house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 1)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house1rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house1rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house1rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }
                // two house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 2)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house2rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house2rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house2rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }
                // three house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 3)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house3rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house3rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house3rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }
                // four house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 4)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house4rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house4rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house4rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }
                //  for hotel 
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 5)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= hotelrent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[3].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= hotelrent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[4].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= hotelrent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[5].SetActive(true);

                    }
                }

                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                StartCoroutine("waittoshowrent");
            }

            /*when property is of third player*/
            if (PanelManager.instance.buyedby[maincounterrent] == 3)
            {
                if (DiceManager.Diceinstance.playerturn == 3)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                // no house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 0)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= RentValue[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= RentValue[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= RentValue[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }
                // one house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 1)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house1rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house1rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house1rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }
                // two house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 2)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house2rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house2rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house2rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }
                // three house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 3)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house3rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house3rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house3rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }
                // fouth house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 4)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house4rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house4rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= house4rent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }
                // for hotel
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 5)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= hotelrent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[6].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= hotelrent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[7].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 4)
                    {
                        PanelManager.instance.player4M -= hotelrent[maincounterrent];
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[8].SetActive(true);

                    }
                }




                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                StartCoroutine("waittoshowrent");
            }

            /*when property is of fourth player*/

            if (PanelManager.instance.buyedby[maincounterrent] == 4)
            {
                if (DiceManager.Diceinstance.playerturn == 4)
                {
                    indiviualRent.transform.gameObject.SetActive(false);
                }
                // no house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 0)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= RentValue[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= RentValue[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= RentValue[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += RentValue[maincounterrent];

                        indiviualRentValue = RentValue[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }
                // one house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 1)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house1rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house1rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house1rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += house1rent[maincounterrent];

                        indiviualRentValue = house1rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }
                // two house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 2)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house2rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house2rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house2rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += house2rent[maincounterrent];

                        indiviualRentValue = house2rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }
                // three house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 3)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house3rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house3rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house3rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += house3rent[maincounterrent];

                        indiviualRentValue = house3rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }
                // fourth house
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 4)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= house4rent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= house4rent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= house4rent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += house4rent[maincounterrent];

                        indiviualRentValue = house4rent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }
                //  for hotel 
                if (Buyhouse.buyhouseinstance.numberofhouse[maincounterrent] == 5)
                {
                    if (DiceManager.Diceinstance.playerturn == 1)
                    {
                        PanelManager.instance.player1M -= hotelrent[maincounterrent];
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[9].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 2)
                    {
                        PanelManager.instance.player2M -= hotelrent[maincounterrent];
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[10].SetActive(true);

                    }
                    if (DiceManager.Diceinstance.playerturn == 3)
                    {
                        PanelManager.instance.player3M -= hotelrent[maincounterrent];
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += hotelrent[maincounterrent];

                        indiviualRentValue = hotelrent[maincounterrent];
                        indiviualRent.text = indiviualRentValue.ToString();
                        RentImage[11].SetActive(true);

                    }
                }

                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                StartCoroutine("waittoshowrent");
            }

        }




    }

    IEnumerator waittoshowrent()
    {
        yield return new WaitForSeconds(3);
        for(int i = 0; i < 12; i++)
        {
            RentImage[i].SetActive(false);
        }
        indiviualRent.transform.gameObject.SetActive(false);
        RentPanel.transform.gameObject.SetActive(false);

    }


}
