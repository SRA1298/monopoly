using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class runtimeplayername : MonoBehaviour
{
    public GameObject lefttradingplayername1, lefttradingplayername2, lefttradingplayername3, lefttradingplayername4;
    public GameObject righttradingplayername1, righttradingplayername2, righttradingplayername3, righttradingplayername4;
    public GameObject gameoverplayer1, gameoverplayer2, gameoverplayer3, gameoverplayer4;
    public GameObject citiesplayer1, citiesplayer2, citiesplayer3, citiesplayer4;
    public GameObject remainingplayer1, remainingplayer2, remainingplayer3, remainingplayer4;
    public GameObject gameover1, gameover2, gameover3, gameover4;
    private void Awake()
    {
        if(menuscripts.menuinstance.gameisonline == false)
        {
            lefttradingplayername1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            lefttradingplayername2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            lefttradingplayername3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            lefttradingplayername4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            righttradingplayername1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            righttradingplayername2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            righttradingplayername3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            righttradingplayername4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            gameoverplayer1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            gameoverplayer2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            gameoverplayer3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            gameoverplayer4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            citiesplayer1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            citiesplayer2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            citiesplayer3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            citiesplayer4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            remainingplayer1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            remainingplayer2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            remainingplayer3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            remainingplayer4.GetComponent<Text>().text = PlayerSelection.instance.player4name;

            gameover1.GetComponent<Text>().text = PlayerSelection.instance.player1name;
            gameover2.GetComponent<Text>().text = PlayerSelection.instance.player2name;
            gameover3.GetComponent<Text>().text = PlayerSelection.instance.player3name;
            gameover4.GetComponent<Text>().text = PlayerSelection.instance.player4name;
        }
       

    }


}
