using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerToken : Photon.MonoBehaviour 
{
    public static PlayerToken playerinstance;
    [Tooltip("The tile the PlayerToken will start on.")]
    [HideInInspector] public Tile startingTile;
    [HideInInspector] public DiceManager diceManager;
    public Text valueText;

    public PhotonView photonview;

    Vector3[] tokenCustomLocation = { new Vector3(-0.13f, 0, -0.14f), new Vector3(0.01f, 0, 0.16f), new Vector3(0.16f, 0, -0.17f), new Vector3(0.31f, 0, 0.13f) };

    [HideInInspector]
    public GameObject[] playersymbolforproperty = new GameObject[41];

    
    Tile currentTile;

    Tile[] moveQueue;
   
    int moveQueueIndex, NumberOfTile = 0;
   

    Vector3 targetPosition;
    Vector3 velocity;

    [HideInInspector] public Tile finalTile;

    int forjail = 0;

    bool jailvisited = false;

    [HideInInspector]
    public bool isplayeratjail;

    public int companyrent = 0;

    bool forjailmodel = false;

    //[HideInInspector]
    //public int onlyforonetime = 1;

    Animator playeranim;
    void Awake()
    {

        startingTile = GameObject.Find("Tile_Holder_Start").gameObject.GetComponent<Tile>();
       
        diceManager = GameObject.Find("DiceManager").gameObject.GetComponent<DiceManager>();

        //valueText = GameObject.Find("value Text").gameObject.GetComponent<Text>();

        playeranim = GetComponent<Animator>();
        isplayeratjail = false;
        finalTile = startingTile;
        print("this is final value from awake" + finalTile);
       
        targetPosition = this.transform.position;
        makeinstance();
       
    }

    void makeinstance()
    {
        if (playerinstance == null)
        {
            playerinstance = this;
        }
    }
   
   
    // Update is called once per frame
    /// <summary>
    /// Moves this object to the desired position which is set by the dice roll.
    /// </summary>
    void Update () 
    {
       
        //if(menuscripts.menuinstance.gameisonline == true)
        //{
        //    if (photonView.isMine)
        //    {
        //        photonView.RPC("movement", PhotonTargets.AllBuffered);
               
        //    }
        //}
        if(menuscripts.menuinstance.gameisonline == false)
        {
           
            if (Vector3.Distance(this.transform.position, targetPosition) > 0.03f && isplayeratjail == false)
            {
                if (forjail == 30)
                {
                    this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.08f);
                }
                else
                {
                    this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.2f);
                }



            }
            else
            {

                if (moveQueue != null && moveQueueIndex <= moveQueue.Length && isplayeratjail == false)
                {
                    playeranim.SetBool("Idle", false);
                    playeranim.SetBool("Run", true);

                    if (forjail != 30)
                    {
                        if (moveQueueIndex < moveQueue.Length)
                        {
                            // GetComponent<AudioSource>().Play();
                           
                            playermovementsound.playersound.normalwalk.PlayOneShot(playermovementsound.playersound.audio1);
                            Tile nextTile = moveQueue[moveQueueIndex];
                            SetNewTargetPosition(nextTile.transform.position);
                            moveQueueIndex++;
                        }
                    }

                    if (forjail == 30)
                    {
                        jailvisited = true;
                        if (moveQueueIndex < moveQueue.Length)
                        {
                            
                            playermovementsound.playersound.jailwalk.PlayOneShot(playermovementsound.playersound.audio2);
                            Tile nextTile = moveQueue[moveQueueIndex];
                            SetNewTargetPosition(nextTile.transform.position);
                            moveQueueIndex++;

                        }
                    }


                    if (moveQueueIndex == moveQueue.Length)
                    {
                        StartCoroutine("cameraplayerstop");
                        if (forjail == 30 && forjailmodel == true)
                        {

                            forjailmodel = false;
                            Instantiate(DiceManager.Diceinstance.jailcage, DiceManager.Diceinstance.jailcage.transform.position, DiceManager.Diceinstance.jailcage.transform.rotation);
                        }
                        print(moveQueueIndex);
                        NumberOfTile += moveQueueIndex;


                        if (NumberOfTile > 40)
                        {
                            NumberOfTile = NumberOfTile - 40;
                            forjail = forjail - 40;
                            if (jailvisited == false)
                            {
                                if (DiceManager.Diceinstance.playerturn == 1)
                                {
                                    PanelManager.instance.player1M += 200;
                                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                                }
                                if (DiceManager.Diceinstance.playerturn == 2)
                                {
                                    PanelManager.instance.player2M += 200;
                                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                                }
                                if (DiceManager.Diceinstance.playerturn == 3)
                                {
                                    PanelManager.instance.player3M += 200;
                                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                                }
                                if (DiceManager.Diceinstance.playerturn == 4)
                                {
                                    PanelManager.instance.player4M += 200;
                                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                                }
                            }

                        }
                        print(NumberOfTile);
                        StartCoroutine("whenplayerstop");
                        moveQueueIndex++;
                    }





                }

            }
        }
       
	}


    //[PunRPC]
    //private void movement()
    //{
    //    if (Vector3.Distance(this.transform.position, targetPosition) > 0.03f && isplayeratjail == false)
    //    {
    //        if (forjail == 30)
    //        {
    //            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.08f);
    //        }
    //        else
    //        {
    //            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.2f);
    //        }



    //    }
    //    else
    //    {

    //        if (moveQueue != null && moveQueueIndex <= moveQueue.Length && isplayeratjail == false)
    //        {

    //            if (forjail != 30)
    //            {
    //                if (moveQueueIndex < moveQueue.Length)
    //                {
    //                    GetComponent<AudioSource>().Play();
    //                    playermovementsound.playersound.normalwalk.PlayOneShot(playermovementsound.playersound.audio1);
    //                    Tile nextTile = moveQueue[moveQueueIndex];
    //                    targetPosition = new Vector3(nextTile.transform.position.x + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].x, nextTile.transform.position.y, nextTile.transform.position.z + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].z);
    //                    velocity = Vector3.zero;
    //                    //SetNewTargetPosition(nextTile.transform.position);
    //                    moveQueueIndex++;
    //                }
    //            }

    //            if (forjail == 30)
    //            {
    //                jailvisited = true;
    //                if (moveQueueIndex < moveQueue.Length)
    //                {
    //                    playermovementsound.playersound.jailwalk.PlayOneShot(playermovementsound.playersound.audio2);
    //                    Tile nextTile = moveQueue[moveQueueIndex];
    //                    targetPosition = new Vector3(nextTile.transform.position.x + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].x, nextTile.transform.position.y, nextTile.transform.position.z + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].z);
    //                    velocity = Vector3.zero;
    //                    //SetNewTargetPosition(nextTile.transform.position);
    //                    moveQueueIndex++;

    //                }
    //            }


    //            if (moveQueueIndex == moveQueue.Length)
    //            {
    //                StartCoroutine("cameraplayerstop");
    //                if (forjail == 30 && forjailmodel == true)
    //                {

    //                    forjailmodel = false;
    //                    Instantiate(DiceManager.Diceinstance.jailcage, DiceManager.Diceinstance.jailcage.transform.position, DiceManager.Diceinstance.jailcage.transform.rotation);
    //                }
    //                print(moveQueueIndex);
    //                NumberOfTile += moveQueueIndex;


    //                if (NumberOfTile > 40)
    //                {
    //                    NumberOfTile = NumberOfTile - 40;
    //                    forjail = forjail - 40;
    //                    if (jailvisited == false)
    //                    {
    //                        if (DiceManager.Diceinstance.playerturn == 1)
    //                        {
    //                            PanelManager.instance.player1M += 200;
    //                            PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
    //                        }
    //                        if (DiceManager.Diceinstance.playerturn == 2)
    //                        {
    //                            PanelManager.instance.player2M += 200;
    //                            PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
    //                        }
    //                        if (DiceManager.Diceinstance.playerturn == 3)
    //                        {
    //                            PanelManager.instance.player3M += 200;
    //                            PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
    //                        }
    //                        if (DiceManager.Diceinstance.playerturn == 4)
    //                        {
    //                            PanelManager.instance.player4M += 200;
    //                            PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
    //                        }
    //                    }

    //                }
    //                print(NumberOfTile);
    //                StartCoroutine("whenplayerstop");
    //                moveQueueIndex++;
    //            }





    //        }

    //    }
    //}

   
    void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = new Vector3(pos.x + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].x, pos.y, pos.z + tokenCustomLocation[DiceManager.Diceinstance.playerturn - 1].z);
        velocity = Vector3.zero;
        
        
    }


    //public void Onlineplayermovement()
    //{
    //    if (menuscripts.menuinstance.gameisonline == true)
    //    {
    //        if (photonView.isMine)
    //        {
               
    //            int spacesToMove = DiceManager.Diceinstance.totalValue;
    //            //if (menuscripts.menuinstance.gameisonline == false)
    //            //{
    //            //    valueText.text = "Value: " + spacesToMove.ToString();
    //            //}

    //            companyrent = spacesToMove * 5;
    //            if (forjail > 40)
    //            {
    //                forjail -= 40;
    //            }

    //            if (spacesToMove == 0)
    //            {
    //                return;
    //            }

    //            jailvisited = false;

    //            forjail = forjail + spacesToMove;

    //            if (DiceManager.Diceinstance.diceList[0].value == DiceManager.Diceinstance.diceList[1].value)
    //            {
    //                if (isplayeratjail == true)
    //                {
    //                    isplayeratjail = false;
    //                }
    //            }

    //            if (DiceManager.Diceinstance.forplayertokenandjail == true)
    //            {
    //                isplayeratjail = false;
    //                DiceManager.Diceinstance.forplayertokenandjail = false;
    //                print("player is out of jail");
    //            }

    //            if (forjail != 30 && isplayeratjail == false)
    //            {
    //                moveQueue = new Tile[spacesToMove];

    //                for (int i = 0; i < spacesToMove; i++)
    //                {

    //                    finalTile = finalTile.nextTile;
                       
    //                    moveQueue[i] = finalTile;

    //                }
    //            }

    //            if (forjail == 30 && isplayeratjail == false)
    //            {

    //                moveQueue = new Tile[spacesToMove + 20];

    //                for (int j = 0; j < spacesToMove + 20; j++)
    //                {
    //                    finalTile = finalTile.nextTile;
    //                    moveQueue[j] = finalTile;
    //                }

    //                forjailmodel = true;

    //                StartCoroutine("forthejailfuction");

    //            }


    //            moveQueueIndex = 0;
    //        }
    //    }
    //}






    /// <summary>
    /// Moves the player 1-6 spaces depending on value of the dice roll.
    /// </summary>
    public void MovePlayerToken()
    {
        
        if (menuscripts.menuinstance.gameisonline == false)
        {
            int spacesToMove = DiceManager.Diceinstance.totalValue;
            // valueText.text = "Value: " + spacesToMove.ToString();
            DiceManager.Diceinstance.valuepanel.SetActive(true);
            valueText.text = spacesToMove.ToString();
            StartCoroutine("sechalttoclosevaluepanel");

            companyrent = spacesToMove * 5;
            if (forjail > 40)
            {
                forjail -= 40;
            }

            if (spacesToMove == 0)
            {
                return;
            }

            jailvisited = false;

            forjail = forjail + spacesToMove;

            if (DiceManager.Diceinstance.diceList[0].value == DiceManager.Diceinstance.diceList[1].value)
            {
                if (isplayeratjail == true)
                {
                    isplayeratjail = false;
                }
            }

            if (DiceManager.Diceinstance.forplayertokenandjail == true)
            {
                isplayeratjail = false;
                DiceManager.Diceinstance.forplayertokenandjail = false;
                print("player is out of jail");
            }

            if (forjail != 30 && isplayeratjail == false)
            {
                moveQueue = new Tile[spacesToMove];

                for (int i = 0; i < spacesToMove; i++)
                {
                    finalTile = finalTile.nextTile;
                    moveQueue[i] = finalTile;

                }
            }

            if (forjail == 30 && isplayeratjail == false)
            {

                moveQueue = new Tile[spacesToMove + 20];

                for (int j = 0; j < spacesToMove + 20; j++)
                {
                    finalTile = finalTile.nextTile;
                    moveQueue[j] = finalTile;
                }

                forjailmodel = true;

                StartCoroutine("forthejailfuction");

            }


            moveQueueIndex = 0;
        }


       
    }


    public void dependentjail()
    {

        DiceManager.Diceinstance.jailpanel.transform.gameObject.SetActive(false);
        DiceManager.Diceinstance.RollButton.transform.gameObject.SetActive(true);
        DiceManager.Diceinstance.EndTurnButton.transform.gameObject.SetActive(false);
        if (DiceManager.Diceinstance.playerturn == 1)
        {
            PanelManager.instance.player1M -= 100;
            PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
            isplayeratjail = false;
        }
        if (DiceManager.Diceinstance.playerturn == 2)
        {
            PanelManager.instance.player2M -= 100;
            PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
            isplayeratjail = false;
        }
        if (DiceManager.Diceinstance.playerturn == 3)
        {
            PanelManager.instance.player3M -= 100;
            PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
            isplayeratjail = false;
        }
        if (DiceManager.Diceinstance.playerturn == 4)
        {
            PanelManager.instance.player4M -= 100;
            PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
            isplayeratjail = false;
        }

    }

    // this is used to wait the operation of rent and buy option for some seconds
    IEnumerator whenplayerstop()
    {
        yield return new WaitForSeconds(0.7f);

        RentFunctionality.Rentinstance.RentFunction(NumberOfTile);
        PanelManager.instance.ShowpanelImage(NumberOfTile);
        playeranim.SetBool("Idle", true);
        playeranim.SetBool("Run", false);
        //print("perfect");

    }

    // this is used to close the value panel
    IEnumerator sechalttoclosevaluepanel()
    {
        yield return new WaitForSeconds(0.5f);
        DiceManager.Diceinstance.valuepanel.SetActive(false);

    }


    // this is used to wait the camera until the player complete the movement 
    IEnumerator cameraplayerstop()
    {
        yield return new WaitForSeconds(0.5f);

        DiceManager.Diceinstance.cameracontrol = false;
        followscripts.camerainstance.cameraattopfunction(NumberOfTile);

    }


    IEnumerator forthejailfuction()
    {
        yield return new WaitForSeconds(10);

        if (DiceManager.Diceinstance.playerturn == 1)
        {
            isplayeratjail = true;

        }
        if (DiceManager.Diceinstance.playerturn == 2)
        {
            isplayeratjail = true;

        }
        if (DiceManager.Diceinstance.playerturn == 3)
        {
            isplayeratjail = true;

        }
        if (DiceManager.Diceinstance.playerturn == 4)
        {
            isplayeratjail = true;

        }
    }


    // this function is created to show which player have bought which city
    public void playersymbol(int r)
    {
        if (DiceManager.Diceinstance.playerturn == 1) 
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[0]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));   

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            } 
        }

        if (DiceManager.Diceinstance.playerturn == 2)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[1]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

        if (DiceManager.Diceinstance.playerturn == 3)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[2]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

        if (DiceManager.Diceinstance.playerturn == 4)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[3]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

    }

    // THIS FUNCTION IS USED AFTER THE AUCTION BUTTON IS SELECTED
    public void Auctionplayersymbol(int r, int playernumber)
    {
        if (playernumber == 1)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[0]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

        if (playernumber == 2)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[1]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

        if (playernumber == 3)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[2]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

        if (playernumber == 4)
        {
            playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[3]);
            if (r < 10)
            {
                playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
            }
            if (r > 10 && r < 20)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
            }
            if (r > 20 && r < 30)
            {
                playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

            }
            if (r > 30 && r < 40)
            {
                playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
            }
        }

    }


   


}