using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tradingmoneyscripts : MonoBehaviour
{
    public static tradingmoneyscripts tradingmoneyinstance;

    [HideInInspector]
    public Text lefttransfermoneytext;
    [HideInInspector]
    public Text righttransfermoneytext;
    [HideInInspector]
    public float lefttransfermoney;
    [HideInInspector]
    public float righttransfermoney;
    private void Awake()
    {
        makeinstance();
        lefttransfermoneytext = GetComponent<Text>();
        righttransfermoneytext = GetComponent<Text>();
    }

    void makeinstance()
    {
        if(tradingmoneyinstance == null)
        {
            tradingmoneyinstance = this;
        }
    }

    public void lefttextUpdate(float value)
    {
        lefttransfermoneytext.text = "Rs " + Mathf.RoundToInt(value * 50);
        lefttransfermoney = value * 50;
        print(lefttransfermoney);

    }

    public void righttextUpdate(float value)
    {
        righttransfermoneytext.text = "Rs " + Mathf.RoundToInt(value * 50);
        righttransfermoney = value * 50;
        print(righttransfermoney);


    }

}
