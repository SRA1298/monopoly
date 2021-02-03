using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    public static TimerCountDown countdowninstance;

    public GameObject gameoverpanel;

    public GameObject textDisplay;
    public float hoursLeft;
    public float minutesLeft;
    public int secondsLeft = 60;
    public bool takingAway = false;
    public GameObject timerbg;
    //[HideInInspector] public bool timerforonetime = true;

    //Start is called before the first frame update
    void Awake()
    {
        timerbg.transform.gameObject.SetActive(false);
        makeinstance();
        if(menuscripts.menuinstance.istimer == true)
        {
            hoursLeft = ShowTime.showinstance.hourvalue;
            textDisplay.GetComponent<Text>().text = "Time : " + (hoursLeft - 1) + ":" + minutesLeft + ":" + secondsLeft;
            
        }
       
    }

  
    void makeinstance()
    {
        if (countdowninstance == null)
        {
            countdowninstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (takingAway == false && secondsLeft >= 0 && menuscripts.menuinstance.istimer == true && menuscripts.menuinstance.gameisonline == false)
        {
            timerbg.transform.gameObject.SetActive(true);
            StartCoroutine("TimerTake");
        }
        if (takingAway == false && secondsLeft >= 0 && menuscripts.menuinstance.gameisonline == true)
        {
            timerbg.transform.gameObject.SetActive(true);
            StartCoroutine("TimerTake");
        }

        if (hoursLeft <= 0 && minutesLeft == 0 && secondsLeft == 0)
        {
            gameover.gameoverinstance.gameoverfunction();
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "Time : " + (hoursLeft - 1) + ":" + minutesLeft + ":" + secondsLeft;
        if (secondsLeft == 0)
        {
            secondsLeft = 60;
            minutesLeft -= 1;
            if (minutesLeft == 0)
            {
                minutesLeft = 59;
                hoursLeft -= 1;
            }
        }

        takingAway = false;
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            
            stream.SendNext(textDisplay.GetComponent<Text>().text);
            

        }
        else if (stream.isReading)
        {
           
            textDisplay.GetComponent<Text>().text = (string)stream.ReceiveNext();
           

        }
    }


}
