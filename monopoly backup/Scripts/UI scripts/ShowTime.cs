using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public static ShowTime showinstance;
    [HideInInspector]
    public float hourvalue;
    [HideInInspector]
    public float minutesvalue;
    [HideInInspector]
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        makeinstance();
        timeText = GetComponent<Text>();
    }

   
    void makeinstance()
    {
        if (showinstance == null)
        {
            showinstance = this;
        }
    }
    [PunRPC]
    public void timeUpdate(float value)
    {
        hourvalue = value * 1;
        timeText.text = hourvalue + " hr ";
    }
}
