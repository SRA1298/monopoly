using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChancesScripts : MonoBehaviour
{
    public static ChancesScripts chanceinstance;

    public GameObject chancePanel;

    public GameObject[] chanceImage;

    [HideInInspector]
    public int chancevalue;

     void Awake()
    {
        chanceImage[0] = GameObject.Find("chance 1");
        chanceImage[0].SetActive(false);

        chanceImage[1] = GameObject.Find("chance 2");
        chanceImage[1].SetActive(false);

        chanceImage[2] = GameObject.Find("chance 3");
        chanceImage[2].SetActive(false);

        chanceImage[3] = GameObject.Find("chance 4");
        chanceImage[3].SetActive(false);

        chanceImage[4] = GameObject.Find("chance 5");
        chanceImage[4].SetActive(false);

        chancePanel.transform.gameObject.SetActive(false);

        makeinstance();

    }

    void makeinstance()
    {
        if (chanceinstance == null)
        {
            chanceinstance = this;
        }
    }


    public void chanceFunction()
    {
        chancevalue = Random.Range(1, 5);
        if(chancevalue == 1)
        {
            // bank plays you dividend of 50
            chancePanel.transform.gameObject.SetActive(true);
            chanceImage[0].SetActive(true);
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
            
            StartCoroutine("waitchance");
        }

        if(chancevalue == 2)
        {
            // pay poor tax of 15
            chancePanel.transform.gameObject.SetActive(true);
            chanceImage[1].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M -= 15;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M -= 15;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M -= 15;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M -= 15;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }
            
            StartCoroutine("waitchance");
        }

        if (chancevalue == 3)
        {
            // you have been elected chairman of the board pay each player 50
            chancePanel.transform.gameObject.SetActive(true);
            chanceImage[2].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                if (DiceManager.Diceinstance.howmanyplayer == 2)
                {
                    PanelManager.instance.player1M -= 50;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

                }
                if (DiceManager.Diceinstance.howmanyplayer == 3)
                {
                    PanelManager.instance.player1M -= 100;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player3M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player1M -= 150;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player3M += 50;
                    PanelManager.instance.player4M += 50;
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
                    PanelManager.instance.player2M -= 50;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

                }
                if (DiceManager.Diceinstance.howmanyplayer == 3)
                {
                    PanelManager.instance.player2M -= 100;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player3M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player2M -= 150;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player3M += 50;
                    PanelManager.instance.player4M += 50;
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
                    PanelManager.instance.player3M -= 100;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                }
                if (DiceManager.Diceinstance.howmanyplayer == 4)
                {
                    PanelManager.instance.player3M -= 150;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player4M += 50;
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
                    PanelManager.instance.player4M -= 150;
                    PanelManager.instance.player2M += 50;
                    PanelManager.instance.player3M += 50;
                    PanelManager.instance.player1M += 50;
                    PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                    PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                    PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                    PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                }
            }
            StartCoroutine("waitchance");
        }

        if (chancevalue == 4)
        {
            // your building and loan matures collect 150
            chancePanel.transform.gameObject.SetActive(true);
            chanceImage[3].SetActive(true);
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                PanelManager.instance.player1M += 150;
                PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                PanelManager.instance.player2M += 150;
                PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 3)
            {
                PanelManager.instance.player3M += 150;
                PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

            }
            if (DiceManager.Diceinstance.playerturn == 4)
            {
                PanelManager.instance.player4M += 150;
                PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

            }
            StartCoroutine("waitchance");

        }

        if (chancevalue == 5)
        {
            // you have won a crossword competition collect 100
            chancePanel.transform.gameObject.SetActive(true);
            chanceImage[4].SetActive(true);
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
            StartCoroutine("waitchance");
        }
    }

    IEnumerator waitchance()
    {
        yield return new WaitForSeconds(4f);

       
        chanceImage[0].SetActive(false);
        chanceImage[1].SetActive(false);
        chanceImage[2].SetActive(false); ;
        chanceImage[3].SetActive(false);
        chanceImage[4].SetActive(false);
        chancePanel.transform.gameObject.SetActive(false);

    }

}
