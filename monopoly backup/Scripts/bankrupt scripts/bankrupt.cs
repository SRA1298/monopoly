using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bankrupt : MonoBehaviour
{
    public static bankrupt bankruptinstance;

    [HideInInspector]
    public bool[] isplayerbankrupt = new bool[5];

    public GameObject bankruptpanel;

    bool[] clickedNobutton = new bool[5];
    private void Awake()
    {
        makeinstance();
        bankruptpanel.transform.gameObject.SetActive(false);
        for (int i = 0; i < 5; i++)
        {
            isplayerbankrupt[i] = false;
        }
    }

    void makeinstance()
    {
        if (bankruptinstance == null)
        {
            bankruptinstance = this;
        }
    }
    // Update is called once per frame
    public void bankruptfunction()
    {
        
        if (DiceManager.Diceinstance.playerturn == 1 && PanelManager.instance.player1M < 0 && clickedNobutton[1] == false)
        {
            bankruptpanel.transform.gameObject.SetActive(true);
        }
        if (DiceManager.Diceinstance.playerturn == 2 && PanelManager.instance.player2M < 0 && clickedNobutton[2] == false)
        {
            bankruptpanel.transform.gameObject.SetActive(true);
        }
        if (DiceManager.Diceinstance.playerturn == 3 && PanelManager.instance.player3M < 0 && clickedNobutton[3] == false)
        {
            bankruptpanel.transform.gameObject.SetActive(true);
        }
        if (DiceManager.Diceinstance.playerturn == 4 && PanelManager.instance.player4M < 0 && clickedNobutton[4] == false)
        {
            bankruptpanel.transform.gameObject.SetActive(true);
        }

        if(PlayerSelection.instance.player == 4)
        {
            if (isplayerbankrupt[1] == true && isplayerbankrupt[2] == true && isplayerbankrupt[3] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[1] == true && isplayerbankrupt[2] == true && isplayerbankrupt[4] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[1] == true && isplayerbankrupt[3] == true && isplayerbankrupt[4] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[2] == true && isplayerbankrupt[3] == true && isplayerbankrupt[4] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }
        }

        if (PlayerSelection.instance.player == 3)
        {
            if (isplayerbankrupt[1] == true && isplayerbankrupt[2] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[1] == true && isplayerbankrupt[3] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[2] == true && isplayerbankrupt[3] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }
        }

        if (PlayerSelection.instance.player == 2)
        {
            if (isplayerbankrupt[1] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }

            if (isplayerbankrupt[2] == true)
            {
                gameover.gameoverinstance.gameoverfunction();
            }
        }
    }

    public void Nobutton()
    {
        if (DiceManager.Diceinstance.playerturn == 1)
        {
            clickedNobutton[1] = true;
        }

        if (DiceManager.Diceinstance.playerturn == 2)
        {
            clickedNobutton[2] = true;
        }
        if (DiceManager.Diceinstance.playerturn == 3)
        {
            clickedNobutton[3] = true;
        }

        if (DiceManager.Diceinstance.playerturn == 4)
        {
            clickedNobutton[4] = true;
        }
        bankruptpanel.transform.gameObject.SetActive(false);
        StartCoroutine("makeclickedNobuttonfalse");
    }
    public void YesButton()
    {
        if (DiceManager.Diceinstance.playerturn == 1)
        {
            isplayerbankrupt[1] = true;
            DiceManager.Diceinstance.blue.SetActive(false);
            PanelManager.instance.player1M = 1;
        }

        if (DiceManager.Diceinstance.playerturn == 2)
        {
            isplayerbankrupt[2] = true;
            DiceManager.Diceinstance.green.SetActive(false);
            PanelManager.instance.player2M = 1;
        }

        if (DiceManager.Diceinstance.playerturn == 3)
        {
            isplayerbankrupt[3] = true;
            DiceManager.Diceinstance.red.SetActive(false);
            PanelManager.instance.player3M = 1;
        }

        if (DiceManager.Diceinstance.playerturn == 4)
        {
            isplayerbankrupt[4] = true;
            DiceManager.Diceinstance.yellow.SetActive(false);
            PanelManager.instance.player4M = 1;
        }
        bankruptpanel.transform.gameObject.SetActive(false);
    }


    IEnumerator makeclickedNobuttonfalse()
    {
        yield return new WaitForSeconds(5);

        for(int w = 0; w < 5; w++)
        {
            clickedNobutton[0] = false;
        }
    }
}


