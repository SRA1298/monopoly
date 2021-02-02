using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DiceManager : MonoBehaviour 
{
    public static DiceManager Diceinstance;

    
    public List<Dice> diceList;
    public int totalValue;
    public UnityEvent EndRollEventBlue;
    public UnityEvent EndRollEventGreen;
    public UnityEvent EndRollEventRed;
    public UnityEvent EndRollEventYellow;

    public GameObject playername1, playername2, playername3, playername4;
    
    public GameObject blue;
   
    public GameObject green;

    public GameObject red;
   
    public GameObject yellow;

    [HideInInspector]
    public GameObject PlayerMoney1, PlayerMoney2, PlayerMoney3, PlayerMoney4;

    [HideInInspector]
    public int playerturn;
    [HideInInspector]
    public int howmanyplayer;

    int turn = 1;

    public GameObject RollButton;
    public GameObject EndTurnButton;

    [HideInInspector]
    public bool doubleroll = false;

    public GameObject rolldoublepanel;

    public GameObject jailpanel;

    [HideInInspector]
    public bool forplayertokenandjail = false;

    int onlyforonce = 0;

    [HideInInspector]
    public bool cameracontrol = false;

    public GameObject jailcage;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
  

    void Awake()
    {
        makeinstance();
       
        if(menuscripts.menuinstance.gameisonline == false)
        {
            playername1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            playername2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            playername3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            playername4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            if (PlayerSelection.instance.player == 2)
            {
                howmanyplayer = 2;
                red.SetActive(false);
                yellow.SetActive(false);

                PlayerMoney3.SetActive(false);
                PlayerMoney4.SetActive(false);

            }
            if (PlayerSelection.instance.player == 3)
            {
                howmanyplayer = 3;
                yellow.SetActive(false);
                PlayerMoney4.SetActive(false);
            }
            if (PlayerSelection.instance.player == 4)
            {
                howmanyplayer = 4;
            }


        }

        if(menuscripts.menuinstance.gameisonline == true)
        {
            if (PlayerSelection.instance.player == 2)
            {
                howmanyplayer = 2;
               
                PlayerMoney3.SetActive(false);
                PlayerMoney4.SetActive(false);

            }
            if (PlayerSelection.instance.player == 3)
            {
                howmanyplayer = 3;
               
                PlayerMoney4.SetActive(false);
            }
            if (PlayerSelection.instance.player == 4)
            {
                howmanyplayer = 4;
            }
        }
      
        jailpanel.transform.gameObject.SetActive(false);
        RollButton.transform.gameObject.SetActive(true);
        EndTurnButton.transform.gameObject.SetActive(false);
        rolldoublepanel.transform.gameObject.SetActive(false);

        
      

    }

   

    void makeinstance()
    {
        if(Diceinstance == null)
        {
            Diceinstance = this;
        }
    }

    // this below function is online roll all die function 
    public void OnlineRollAllDie()
    {

        followscripts.camerainstance.Stoptheanimator();
        jailpanel.transform.gameObject.SetActive(false);

        totalValue = 0;
        for (int i = 0; i < diceList.Count; i++)
        {
            diceList[i].AddForceToDice();
        }

        RollButton.transform.gameObject.SetActive(false);
        EndTurnButton.transform.gameObject.SetActive(true);
        cameracontrol = true;

        if (onlinecorrection.onlinecorrectioninstance.onlineplayerturn1 == true)
        {
            playerturn = 1;
        }

        if (onlinecorrection.onlinecorrectioninstance.onlineplayerturn2 == true)
        {
            playerturn = 2;
        }

        if (onlinecorrection.onlinecorrectioninstance.onlineplayerturn3 == true)
        {
            playerturn = 3;
        }

        if (onlinecorrection.onlinecorrectioninstance.onlineplayerturn4 == true)
        {
            playerturn = 4;
        }


        if (playerturn == 1)
        {
            player1.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 2)
        {
            player2.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 3)
        {
            player3.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 4)
        {
            player4.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }

    }




    // this below function is offline roll all die function
    public void RollAllDie()
    {
        followscripts.camerainstance.Stoptheanimator();

        //TimerCountDown.countdowninstance.timerfunction();
        jailpanel.transform.gameObject.SetActive(false);

        totalValue = 0;
        //reset total value

        for (int i = 0; i < diceList.Count; i++)
        {
            diceList[i].AddForceToDice();
        }

        if (turn == 1 && onlyforonce == 0)
        {
            playerturn = 1;
            print("turn of first player");
            //turn = 2;
            onlyforonce = 1;

        }

        RollButton.transform.gameObject.SetActive(false);
        EndTurnButton.transform.gameObject.SetActive(true);
        cameracontrol = true;

        if (playerturn == 1)
        {
            player1.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 2)
        {
            player2.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 3)
        {
            player3.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }
        if (playerturn == 4)
        {
            player4.transform.localScale = new Vector3(1.3f, 1.3f, 0);
        }

    }

    /*this below function is made for the online countalldievalues */
    public void Onlinecountalldievalues()
    {
        for (int i = 0; i < diceList.Count; i++)
        {
            if (diceList[i].isRolling == true)
            {
                totalValue = 0;
                return;
            }
            else
            {
                totalValue += diceList[i].value;
            }
        }

        if (diceList[0].value == diceList[1].value)
        {
            doubleroll = true;
        }

        if (playerturn == 1)
        {
            player1token.player1instance.Onlineplayer1movement();
        }
        if (playerturn == 2)
        {
            player2token.player2instance.Onlineplayer2movement();

        }
        if (playerturn == 3)
        {
            Player3Token.player3instance.Onlineplayer3movement();
           // PlayerToken.playerinstance.Onlineplayermovement();
        }
        if (playerturn == 4)
        {
            player4Token.player4instance.Onlineplayer4movement();
            //PlayerToken.playerinstance.Onlineplayermovement();
        }

        if (doubleroll == true)
        {
            rolldoublepanel.transform.gameObject.SetActive(true);
            RollButton.transform.gameObject.SetActive(true);
            EndTurnButton.transform.gameObject.SetActive(false);
            doubleroll = false;
            StartCoroutine("rolldoublefunction");
        }
    }



    /*this is the main offline countalldievalues function*/
    public void CountAllDieValues()
    {
        for (int i = 0; i < diceList.Count; i++)
        {
            if(diceList[i].isRolling == true)
            {
                totalValue = 0;
                return;
            }
            else
            {
                totalValue += diceList[i].value;
            }
        }

        if (diceList[0].value == diceList[1].value)
        {
            doubleroll = true;
        }
        
        if (turn == 1)
        {
            EndRollEventBlue.Invoke();
        }
        else if (turn == 2)
        {
            EndRollEventGreen.Invoke();
        }
        if (turn == 3)
        {
            EndRollEventRed.Invoke();
        }
        else if (turn == 4)
        {
            EndRollEventYellow.Invoke();
        }

        if (doubleroll == true)
        {
            rolldoublepanel.transform.gameObject.SetActive(true);
            RollButton.transform.gameObject.SetActive(true);
            EndTurnButton.transform.gameObject.SetActive(false);
            doubleroll = false;
            StartCoroutine("rolldoublefunction");
        }

    }


    //this function is used for the online game
    public void OnlineEndTurn()
    {
        //bankrupt.bankruptinstance.bankruptfunction();

        if (playerturn == 1)
        {
            player1.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 2)
        {
            player2.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 3)
        {
            player3.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 4)
        {
            player4.transform.localScale = new Vector3(1, 1, 0);
        }

        RollButton.transform.gameObject.SetActive(true);
        EndTurnButton.transform.gameObject.SetActive(false);


    }




    // this below fuction is used to end turn of the player in a offline game
    public void EndTurn()
    {
        if (playerturn == 1)
        {
            player1.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 2)
        {
            player2.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 3)
        {
            player3.transform.localScale = new Vector3(1, 1, 0);
        }
        if (playerturn == 4)
        {
            player4.transform.localScale = new Vector3(1, 1, 0);
        }


        if (turn == 1)
        {
           
            turn = 2;
            if(PlayerSelection.instance.player == 2)
            {
                if (bankrupt.bankruptinstance.isplayerbankrupt[2] == true)
                {
                    turn = 1;
                }
            }
            else
            {
                if (bankrupt.bankruptinstance.isplayerbankrupt[2] == true)
                {
                    turn = 3;
                }
                if (bankrupt.bankruptinstance.isplayerbankrupt[2] == true && bankrupt.bankruptinstance.isplayerbankrupt[3] == true)
                {
                    turn = 4;
                }
                if (bankrupt.bankruptinstance.isplayerbankrupt[2] == true && bankrupt.bankruptinstance.isplayerbankrupt[3] == true && bankrupt.bankruptinstance.isplayerbankrupt[4] == true)
                {
                    turn = 1;
                }
            }

        }
        else if (turn == 2)
        {
            if (PlayerSelection.instance.player == 2)
            {
             
                turn = 1;
                if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
                {
                    turn = 2;
                }


            }
            else
            {
              
                turn = 3;
                if (PlayerSelection.instance.player == 3)
                {
                    if (bankrupt.bankruptinstance.isplayerbankrupt[3] == true)
                    {
                        turn = 1;
                    }
                    if (bankrupt.bankruptinstance.isplayerbankrupt[3] == true && bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
                    {
                        turn = 2;

                    }
                }
                else
                {
                    if (bankrupt.bankruptinstance.isplayerbankrupt[3] == true)
                    {
                        turn = 4;
                    }
                    if (bankrupt.bankruptinstance.isplayerbankrupt[3] == true && bankrupt.bankruptinstance.isplayerbankrupt[4] == true)
                    {
                        turn = 1;
                    }
                    if (bankrupt.bankruptinstance.isplayerbankrupt[3] == true && bankrupt.bankruptinstance.isplayerbankrupt[4] == true && bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
                    {
                        turn = 2;
                    }

                }
            }

        }
        else if (turn == 3)
        {
            if (PlayerSelection.instance.player == 3)
            {

                turn = 1;
                if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
                {
                    turn = 2;
                }
                if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true && bankrupt.bankruptinstance.isplayerbankrupt[2] == true)
                {
                    turn = 3;
                }
                
                


            }
            else
            {
               
                turn = 4;
                if(bankrupt.bankruptinstance.isplayerbankrupt[4] == true)
                {
                    turn = 1;
                }
                if(bankrupt.bankruptinstance.isplayerbankrupt[4] == true && bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
                {
                    turn = 2;
                }
                if(bankrupt.bankruptinstance.isplayerbankrupt[4] == true && bankrupt.bankruptinstance.isplayerbankrupt[1] == true && bankrupt.bankruptinstance.isplayerbankrupt[2] == true)
                {
                    turn = 3;
                }


            }

        }
        else if (turn == 4)
        {
          
            turn = 1;
            if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true)
            {
                turn = 2;
            }
            if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true && bankrupt.bankruptinstance.isplayerbankrupt[2] == true)
            {
                turn = 3;
            }
            if(bankrupt.bankruptinstance.isplayerbankrupt[1] == true && bankrupt.bankruptinstance.isplayerbankrupt[2] == true && bankrupt.bankruptinstance.isplayerbankrupt[3] == true)
            {
                turn = 4;
            }


        }
       
       

        if (turn == 1)
        {
            playerturn = 1;
            print("turn of first player");
            //turn = 2;

        }
        else if (turn == 2)
        {
            if (PlayerSelection.instance.player == 2)
            {
                playerturn = 2;
                print("turn of second player");
                //turn = 1;


            }
            else
            {
                playerturn = 2;
                print("turn of second player");
                //turn = 3;

            }

        }
        else if (turn == 3)
        {
            if (PlayerSelection.instance.player == 3)
            {

                playerturn = 3;
                print("turn of third player");
                //turn = 1;


            }
            else
            {
                playerturn = 3;
                print("turn of third player");
                //turn = 4;

            }

        }
        else if (turn == 4)
        {
            playerturn = 4;
            print("turn of fourth player");
            //turn = 1;


        }

       
        if(menuscripts.menuinstance.gameisonline == false)
        {
            if (playerturn == 1 && PlayerToken.playerinstance.isplayeratjail == true)
            {
                jailpanel.transform.gameObject.SetActive(true);
                RollButton.transform.gameObject.SetActive(false);
                EndTurnButton.transform.gameObject.SetActive(true);
            }
            if (playerturn == 2 && PlayerToken.playerinstance.isplayeratjail == true)
            {
                jailpanel.transform.gameObject.SetActive(true);
                RollButton.transform.gameObject.SetActive(false);
                EndTurnButton.transform.gameObject.SetActive(true);
            }
            if (playerturn == 3 && PlayerToken.playerinstance.isplayeratjail == true)
            {
                jailpanel.transform.gameObject.SetActive(true);
                RollButton.transform.gameObject.SetActive(false);
                EndTurnButton.transform.gameObject.SetActive(true);
            }
            if (playerturn == 4 && PlayerToken.playerinstance.isplayeratjail == true)
            {
                jailpanel.transform.gameObject.SetActive(true);
                RollButton.transform.gameObject.SetActive(false);
                EndTurnButton.transform.gameObject.SetActive(true);
            }
        }
       

        bankrupt.bankruptinstance.bankruptfunction();

        RollButton.transform.gameObject.SetActive(true);
        EndTurnButton.transform.gameObject.SetActive(false);

       

    }


    public void paymoneyandfreefromjail()
    {
        forplayertokenandjail = true;
        jailcage.SetActive(false);
        if(menuscripts.menuinstance.gameisonline == false)
        {
            PlayerToken.playerinstance.dependentjail();
        }
        if(menuscripts.menuinstance.gameisonline == true)
        {
            if (playerturn == 1)
            {
                player1token.player1instance.dependentjail();
            }
            if (playerturn == 2)
            {
                player2token.player2instance.dependentjail();
            }
            if (playerturn == 3)
            {
                Player3Token.player3instance.dependentjail();
            }
            if (playerturn == 4)
            {
                player4Token.player4instance.dependentjail();
               
            }
        }
      

    }

    public void specialjailbutton()
    {
        jailpanel.transform.gameObject.SetActive(true);
        RollButton.transform.gameObject.SetActive(false);
        EndTurnButton.transform.gameObject.SetActive(true);
    }


    IEnumerator rolldoublefunction()
    {
        yield return new WaitForSeconds(1);
        rolldoublepanel.transform.gameObject.SetActive(false);
    }
}