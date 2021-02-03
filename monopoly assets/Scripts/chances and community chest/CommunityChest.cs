using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunityChest : MonoBehaviour
{
    public static CommunityChest communityinstance;

    public GameObject communityPanel;

    public GameObject[] communityImage;

    [HideInInspector]
    public int communityvalue;

    void Awake()
    {
        communityImage[0] = GameObject.Find("community 1");
        communityImage[0].SetActive(false);

        communityImage[1] = GameObject.Find("community 2");
        communityImage[1].SetActive(false);

        communityImage[2] = GameObject.Find("community 3");
        communityImage[2].SetActive(false);

        communityImage[3] = GameObject.Find("community 4");
        communityImage[3].SetActive(false);

        communityImage[4] = GameObject.Find("community 5");
        communityImage[4].SetActive(false);

        communityImage[5] = GameObject.Find("community 6");
        communityImage[5].SetActive(false);

        communityImage[6] = GameObject.Find("community 7");
        communityImage[6].SetActive(false);

        communityImage[7] = GameObject.Find("community 8");
        communityImage[7].SetActive(false);

        communityImage[8] = GameObject.Find("community 9");
        communityImage[8].SetActive(false);

        communityImage[9] = GameObject.Find("community 10");
        communityImage[9].SetActive(false);

        communityImage[10] = GameObject.Find("community 11");
        communityImage[10].SetActive(false);

        communityImage[11] = GameObject.Find("community 12");
        communityImage[11].SetActive(false);

        communityImage[12] = GameObject.Find("community 13");
        communityImage[12].SetActive(false);


        communityPanel.transform.gameObject.SetActive(false);

        makeinstance();
    }

    void makeinstance()
    {
        if(communityinstance == null)
        {
            communityinstance = this;
        }
    }


    public void communitychestfunction()
    {
        communityvalue = Random.Range(1, 13);
        if (communityvalue == 1)
        {
            // bank error collect 200
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[0].SetActive(true);
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

            StartCoroutine("waitcommunity");

        }

        if(communityvalue == 2)
        {
            // doctor fee pay 50
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[1].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M -= 50;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M -= 50;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M -= 50;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M -= 50;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }
            StartCoroutine("waitcommunity");
        }

        if (communityvalue == 3)
        {
            //sale of stock you get 50
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[2].SetActive(true);

            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 50;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 50;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 50;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 50;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }

        if (communityvalue == 4)
        {
            // grand opera night collect 50 from everyone
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[3].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                if (DiceManager.Diceinstance.howmanyplayer == 2)
                {
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

                }
                if (DiceManager.Diceinstance.howmanyplayer == 3)
                {
                    PanelManager.instance.player1M += 100;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player3M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player1M += 150;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player3M -= 50;
                    PanelManager.instance.player4M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                }
            }

            if (DiceManager.Diceinstance.playerturn == 2)
            {
                if (DiceManager.Diceinstance.howmanyplayer == 2)
                {
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

                }
                if (DiceManager.Diceinstance.howmanyplayer == 3)
                {
                    PanelManager.instance.player2M += 100;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player3M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player2M += 150;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player3M -= 50;
                    PanelManager.instance.player4M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                }
            }

            if (DiceManager.Diceinstance.playerturn == 3)
            {

                if (DiceManager.Diceinstance.howmanyplayer == 3)
                {
                    PanelManager.instance.player3M += 100;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player3M += 150;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player4M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                }
            }

            if (DiceManager.Diceinstance.playerturn == 4)
            {

                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player4M += 150;
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player3M -= 50;
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                }
            }

            StartCoroutine("waitcommunity");

        }

        if(communityvalue == 5)
        {
            // holiday fund matures receive 100
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[4].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 100;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 100;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 100;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 100;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");

        }

        if (communityvalue == 6)
        {
            // income tax refund collect 20
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[5].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 20;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 20;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 20;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 20;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");

        }


        if (communityvalue == 7)
        {
            // birthday collect 10
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[6].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 10;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 10;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 10;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 10;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }

        if (communityvalue == 8)
        {
            // life insurance collect 100
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[7].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 100;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 100;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 100;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 100;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }

        if (communityvalue == 9)
        {
            // pay hospital fee of 100
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[8].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M -= 100;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M -= 100;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M -= 100;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M -= 100;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }

        if (communityvalue == 10)
        {
            // pay school fee 150
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[9].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M -= 150;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M -= 150;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M -= 150;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M -= 150;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");

        }

        if (communityvalue == 11)
        {
            // consultancy fee collect 25
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[10].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 25;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 25;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 25;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 25;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");

        }

        if (communityvalue == 12)
        {
            // beauty contest second winner collect 10
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[11].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 10;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 10;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 10;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 10;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }


        if(communityvalue == 13)
        {
            // you inherit 100
            communityPanel.transform.gameObject.SetActive(true);
            communityImage[12].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 100;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 100;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 100;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 100;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }

            StartCoroutine("waitcommunity");
        }

    }


    IEnumerator waitcommunity()
    {
        yield return new WaitForSeconds(4f);

        communityImage[0].SetActive(false);
        communityImage[1].SetActive(false);
        communityImage[2].SetActive(false);
        communityImage[3].SetActive(false);
        communityImage[4].SetActive(false);
        communityImage[5].SetActive(false);
        communityImage[6].SetActive(false);
        communityImage[7].SetActive(false);
        communityImage[8].SetActive(false);
        communityImage[9].SetActive(false);
        communityImage[10].SetActive(false);
        communityImage[11].SetActive(false);
        communityImage[12].SetActive(false);
        
        communityPanel.transform.gameObject.SetActive(false);



    }



}
