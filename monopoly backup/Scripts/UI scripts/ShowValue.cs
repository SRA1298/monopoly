using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    public static ShowValue showinstance;
    [HideInInspector]
    public Text moneyText;
    [HideInInspector]
    public float printvalue;
    

    void Start()
    {
        makeinstance();
        moneyText = GetComponent<Text>();
        
    }

    void makeinstance()
    {
        if (showinstance == null)
        {
            showinstance = this;
        }
    }
    [PunRPC]
    public void textUpdate(float value)
    {
        moneyText.text = "Rs " + Mathf.RoundToInt(value * 1000);
        printvalue = value * 1000;
    }

    
}