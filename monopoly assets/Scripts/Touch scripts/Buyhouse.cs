using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buyhouse : Photon.MonoBehaviour
{
    public static Buyhouse buyhouseinstance;

    public GameObject buyhousepanel;

    public GameObject[] house;

    public GameObject hotel;

    [HideInInspector]
    public int[] numberofhouse = new int[40];

    [HideInInspector]
    public bool clickedbuyhouse = false;

    [HideInInspector]
    public GameObject[] symbolhouse1 = new GameObject[41];

    [HideInInspector]
    public GameObject[] symbolhouse2 = new GameObject[41];

    [HideInInspector]
    public GameObject[] symbolhouse3 = new GameObject[41];

    [HideInInspector]
    public GameObject[] symbolhouse4 = new GameObject[41];

    [HideInInspector]
    public GameObject[] symbolhotel = new GameObject[41];

    float[] buyhousevalue = new float[5];

    float[] playermoneysufficent = new float[5];

    public PhotonView photonview;

    private void Awake()
    {
        makeinstance();
        buyhousepanel.transform.gameObject.SetActive(false);
        for(int i=0; i < 40; i++)
        {
            numberofhouse[i] = 0;
        }

        for(int j = 0; j < 5; j++)
        {
            buyhousevalue[j] = 0;
        }

       
    }

    void makeinstance()
    {
        if(buyhouseinstance == null)
        {
            buyhouseinstance = this;
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
                if (clickedbuyhouse == true)
                {
                    buyhousefunction(hit.transform.gameObject);
                }
                else
                {
                    //print("no operation for buy house");
                }
            }
        }
    }


    public void buyhousefunction(GameObject go)
    {
        if (go.name == "Tile 1")
        {
            buyhousehandler(1);

        }
        if (go.name == "Tile 3")
        {
            buyhousehandler(3);

        }
        //if (go.name == "Tile 5")
        //{
        //    buyhousehandler(5);

        //}
        if (go.name == "Tile 6")
        {
            buyhousehandler(6);

        }
        if (go.name == "Tile 8")
        {
            buyhousehandler(8);

        }
        if (go.name == "Tile 9")
        {
            buyhousehandler(9);

        }
        if (go.name == "Tile 11")
        {
            buyhousehandler(11);

        }
        //if (go.name == "Tile 12")
        //{
        //    buyhousehandler(12);

        //}
        if (go.name == "Tile 13")
        {
            buyhousehandler(13);

        }
        if (go.name == "Tile 14")
        {
            buyhousehandler(14);

        }
        //if (go.name == "Tile 15")
        //{
        //    buyhousehandler(15);

        //}
        if (go.name == "Tile 16")
        {
            buyhousehandler(16);

        }
        if (go.name == "Tile 18")
        {
            buyhousehandler(18);

        }
        if (go.name == "Tile 19")
        {
            buyhousehandler(19);

        }
        if (go.name == "Tile 21")
        {
            buyhousehandler(21);

        }
        if (go.name == "Tile 23")
        {
            buyhousehandler(23);

        }
        if (go.name == "Tile 24")
        {
            buyhousehandler(24);

        }
        //if (go.name == "Tile 25")
        //{
        //    buyhousehandler(25);

        //}
        if (go.name == "Tile 26")
        {
            buyhousehandler(26);

        }
        if (go.name == "Tile 27")
        {
            buyhousehandler(27);

        }
        //if (go.name == "Tile 28")
        //{
        //    buyhousehandler(28);

        //}
        if (go.name == "Tile 29")
        {
            buyhousehandler(29);

        }
        if (go.name == "Tile 31")
        {
            buyhousehandler(31);

        }
        if (go.name == "Tile 32")
        {
            buyhousehandler(32);

        }
        if (go.name == "Tile 34")
        {
            buyhousehandler(34);

        }
        //if (go.name == "Tile 35")
        //{
        //    buyhousehandler(35);

        //}
        if (go.name == "Tile 37")
        {
            buyhousehandler(37);

        }
        if (go.name == "Tile 39")
        {
            buyhousehandler(39);

        }

    }

    void buyhousehandler(int d)
    {
        //int s = d;

        playermoneysufficent[1] = PanelManager.instance.player1M;
        playermoneysufficent[2] = PanelManager.instance.player2M;
        playermoneysufficent[3] = PanelManager.instance.player3M;
        playermoneysufficent[4] = PanelManager.instance.player4M;

        if (PanelManager.instance.cityblockhandler[d] == true && mortgage.mortgageinstance.Ismortgage[d] == false)
        {
            if(DiceManager.Diceinstance.playerturn == 1 && PanelManager.instance.buyedby[d] == 1 )
            {
                buyhousevalue[1] = buildhouse(d,1);       
                if (PanelManager.instance.player1M > buyhousevalue[1])
                {
                    PanelManager.instance.player1M -= buyhousevalue[1];
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    buyhousevalue[1] = 0;
                }
               

            }

            if (DiceManager.Diceinstance.playerturn == 2 && PanelManager.instance.buyedby[d] == 2 )
            {
                buyhousevalue[2] = buildhouse(d,2);
                if(PanelManager.instance.player2M > buyhousevalue[2])
                {
                    PanelManager.instance.player2M -= buyhousevalue[2];
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    buyhousevalue[2] = 0;
                }
               
            }

            if (DiceManager.Diceinstance.playerturn == 3 && PanelManager.instance.buyedby[d] == 3)
            {
                buyhousevalue[3] = buildhouse(d,3);
                if(PanelManager.instance.player3M > buyhousevalue[3])
                {
                    PanelManager.instance.player3M -= buyhousevalue[3];
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    buyhousevalue[3] = 0;

                }
               

            }

            if (DiceManager.Diceinstance.playerturn == 4 && PanelManager.instance.buyedby[d] == 4)
            {
                buyhousevalue[4] = buildhouse(d,4);
                if(PanelManager.instance.player4M > buyhousevalue[4])
                {
                    PanelManager.instance.player4M -= buyhousevalue[4];
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                    buyhousevalue[4] = 0;
                }
                
              
            }

            if(numberofhouse[d] < 6)
            {
                numberofhouse[d] += 1;
                //print("inside if");
                //print(numberofhouse[d]);
                if(numberofhouse[d] == 6)
                {
                    numberofhouse[d] -= 1;
                   // print(numberofhouse[d]);
                }
            }
           
           
        }
    }

    float buildhouse( int d, int value)
    {
        int s = d;
        // the following if condition is used for the offline version 
        if (menuscripts.menuinstance.gameisonline == false)
        {
            //for house one
            if (numberofhouse[d] == 0)
            {

                symbolhouse1[d] = (GameObject)Instantiate(house[0]);
                if (d < 10)
                {
                    //symbolhouse1[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.34f));
                    buyhousevalue[value] = 50;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse1[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.34f));
                    }
                }
                if (d > 10 && d < 20)
                {

                    buyhousevalue[value] = 100;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse1[d].transform.position = new Vector3(-(s - 9.695f), 0.1f, -9.77f);
                    }
                }
                if (d > 20 && d < 30)
                {

                    buyhousevalue[value] = 150;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse1[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s + 0.309f)));
                    }

                }
                if (d > 30 && d < 40)
                {

                    buyhousevalue[value] = 200;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse1[d].transform.position = new Vector3(-(40 - (s + 0.346f)), 0.1f, -0.263f);
                    }

                }



            }
            // for house two
            if (numberofhouse[d] == 1)
            {

                symbolhouse2[d] = (GameObject)Instantiate(house[1]);
                if (d < 10)
                {

                    buyhousevalue[value] = 50;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse2[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.122f));
                    }
                }
                if (d > 10 && d < 20)
                {

                    buyhousevalue[value] = 100;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse2[d].transform.position = new Vector3(-(s - 9.906f), 0.1f, -9.77f);
                    }
                }
                if (d > 20 && d < 30)
                {

                    buyhousevalue[value] = 150;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse2[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s + 0.094f)));
                    }

                }
                if (d > 30 && d < 40)
                {

                    buyhousevalue[value] = 200;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse2[d].transform.position = new Vector3(-(40 - (s + 0.135f)), 0.1f, -0.263f);
                    }
                }

            }
            // for house three
            if (numberofhouse[d] == 2)
            {

                symbolhouse3[d] = (GameObject)Instantiate(house[2]);
                if (d < 10)
                {

                    buyhousevalue[value] = 50;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse3[d].transform.position = new Vector3(-0.233f, 0.1f, -(s - 0.095f));
                    }
                }
                if (d > 10 && d < 20)
                {

                    buyhousevalue[value] = 100;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse3[d].transform.position = new Vector3(-(s - 10.1117f), 0.1f, -9.77f);
                    }
                }
                if (d > 20 && d < 30)
                {

                    buyhousevalue[value] = 150;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse3[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s - 0.119f)));
                    }

                }
                if (d > 30 && d < 40)
                {

                    buyhousevalue[value] = 200;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse3[d].transform.position = new Vector3(-(40 - (s - 0.077f)), 0.1f, -0.263f);
                    }
                }

            }
            // for house four
            if (numberofhouse[d] == 3)
            {

                symbolhouse4[d] = (GameObject)Instantiate(house[3]);
                if (d < 10)
                {

                    buyhousevalue[value] = 50;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse4[d].transform.position = new Vector3(-0.233f, 0.1f, -(s - 0.318f));
                    }
                }
                if (d > 10 && d < 20)
                {

                    buyhousevalue[value] = 100;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse4[d].transform.position = new Vector3(-(s - 10.327f), 0.1f, -9.77f);
                    }
                }
                if (d > 20 && d < 30)
                {

                    buyhousevalue[value] = 150;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse4[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s - 0.33f)));
                    }

                }
                if (d > 30 && d < 40)
                {

                    buyhousevalue[value] = 200;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhouse4[d].transform.position = new Vector3(-(40 - (s - 0.29f)), 0.1f, -0.263f);
                    }
                }
            }
            //for hotel
            if (numberofhouse[d] == 4)
            {
                symbolhouse1[d].SetActive(false);
                symbolhouse2[d].SetActive(false);
                symbolhouse3[d].SetActive(false);
                symbolhouse4[d].SetActive(false);

                symbolhotel[d] = (GameObject)Instantiate(hotel);
                if (d < 10)
                {

                    buyhousevalue[value] = 50;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhotel[d].transform.position = new Vector3(-0.233f, 0.3f, -(s + 0.001f));
                    }

                }
                if (d > 10 && d < 20)
                {

                    buyhousevalue[value] = 100;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhotel[d].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                        symbolhotel[d].transform.position = new Vector3(-(s - 10f), 0.3f, -9.77f);
                    }

                }
                if (d > 20 && d < 30)
                {

                    buyhousevalue[value] = 150;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhotel[d].transform.position = new Vector3(-9.72f, 0.3f, -(30 - s));
                    }

                }
                if (d > 30 && d < 40)
                {

                    buyhousevalue[value] = 200;
                    if (playermoneysufficent[value] > buyhousevalue[value])
                    {
                        symbolhotel[d].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                        symbolhotel[d].transform.position = new Vector3(-(40 - s), 0.3f, -0.263f);
                    }
                }


            }
        }

        // this following if condition is used for the online version
        if (menuscripts.menuinstance.gameisonline == true)
        {
            if (photonView.isMine)
            {
                //for house one
                if (numberofhouse[d] == 0)
                {

                    symbolhouse1[d] = PhotonNetwork.Instantiate(house[0].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                    if (d < 10)
                    {
                        //symbolhouse1[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.34f));
                        buyhousevalue[value] = 50;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse1[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.34f));
                        }
                    }
                    if (d > 10 && d < 20)
                    {

                        buyhousevalue[value] = 100;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse1[d].transform.position = new Vector3(-(s - 9.695f), 0.1f, -9.77f);
                        }
                    }
                    if (d > 20 && d < 30)
                    {

                        buyhousevalue[value] = 150;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse1[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s + 0.309f)));
                        }

                    }
                    if (d > 30 && d < 40)
                    {

                        buyhousevalue[value] = 200;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse1[d].transform.position = new Vector3(-(40 - (s + 0.346f)), 0.1f, -0.263f);
                        }

                    }



                }
                // for house two
                if (numberofhouse[d] == 1)
                {

                    symbolhouse2[d] = PhotonNetwork.Instantiate(house[1].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                    if (d < 10)
                    {

                        buyhousevalue[value] = 50;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse2[d].transform.position = new Vector3(-0.233f, 0.1f, -(s + 0.122f));
                        }
                    }
                    if (d > 10 && d < 20)
                    {

                        buyhousevalue[value] = 100;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse2[d].transform.position = new Vector3(-(s - 9.906f), 0.1f, -9.77f);
                        }
                    }
                    if (d > 20 && d < 30)
                    {

                        buyhousevalue[value] = 150;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse2[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s + 0.094f)));
                        }

                    }
                    if (d > 30 && d < 40)
                    {

                        buyhousevalue[value] = 200;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse2[d].transform.position = new Vector3(-(40 - (s + 0.135f)), 0.1f, -0.263f);
                        }
                    }

                }
                // for house three
                if (numberofhouse[d] == 2)
                {

                    symbolhouse3[d] = PhotonNetwork.Instantiate(house[2].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                    if (d < 10)
                    {

                        buyhousevalue[value] = 50;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse3[d].transform.position = new Vector3(-0.233f, 0.1f, -(s - 0.095f));
                        }
                    }
                    if (d > 10 && d < 20)
                    {

                        buyhousevalue[value] = 100;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse3[d].transform.position = new Vector3(-(s - 10.1117f), 0.1f, -9.77f);
                        }
                    }
                    if (d > 20 && d < 30)
                    {

                        buyhousevalue[value] = 150;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse3[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s - 0.119f)));
                        }

                    }
                    if (d > 30 && d < 40)
                    {

                        buyhousevalue[value] = 200;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse3[d].transform.position = new Vector3(-(40 - (s - 0.077f)), 0.1f, -0.263f);
                        }
                    }

                }
                // for house four
                if (numberofhouse[d] == 3)
                {

                    symbolhouse4[d] = PhotonNetwork.Instantiate(house[3].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                    if (d < 10)
                    {

                        buyhousevalue[value] = 50;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse4[d].transform.position = new Vector3(-0.233f, 0.1f, -(s - 0.318f));
                        }
                    }
                    if (d > 10 && d < 20)
                    {

                        buyhousevalue[value] = 100;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse4[d].transform.position = new Vector3(-(s - 10.327f), 0.1f, -9.77f);
                        }
                    }
                    if (d > 20 && d < 30)
                    {

                        buyhousevalue[value] = 150;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse4[d].transform.position = new Vector3(-9.72f, 0.1f, -(30 - (s - 0.33f)));
                        }

                    }
                    if (d > 30 && d < 40)
                    {

                        buyhousevalue[value] = 200;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhouse4[d].transform.position = new Vector3(-(40 - (s - 0.29f)), 0.1f, -0.263f);
                        }
                    }
                }
                //for hotel
                if (numberofhouse[d] == 4)
                {
                    symbolhouse1[d].SetActive(false);
                    symbolhouse2[d].SetActive(false);
                    symbolhouse3[d].SetActive(false);
                    symbolhouse4[d].SetActive(false);

                    symbolhotel[d] = PhotonNetwork.Instantiate(hotel.name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                    if (d < 10)
                    {

                        buyhousevalue[value] = 50;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhotel[d].transform.position = new Vector3(-0.233f, 0.3f, -(s + 0.001f));
                        }

                    }
                    if (d > 10 && d < 20)
                    {

                        buyhousevalue[value] = 100;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhotel[d].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                            symbolhotel[d].transform.position = new Vector3(-(s - 10f), 0.3f, -9.77f);
                        }

                    }
                    if (d > 20 && d < 30)
                    {

                        buyhousevalue[value] = 150;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhotel[d].transform.position = new Vector3(-9.72f, 0.3f, -(30 - s));
                        }

                    }
                    if (d > 30 && d < 40)
                    {

                        buyhousevalue[value] = 200;
                        if (playermoneysufficent[value] > buyhousevalue[value])
                        {
                            symbolhotel[d].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                            symbolhotel[d].transform.position = new Vector3(-(40 - s), 0.3f, -0.263f);
                        }
                    }


                }

            }
            
        }


        return (buyhousevalue[value]);
        
    }

    public void closebuyhousepanel()
    {
        racastdebugging.rayinstance.clickcityrepresentation = true;
        clickedbuyhouse = false;
        buyhousepanel.transform.gameObject.SetActive(false);
    }

}
