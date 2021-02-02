using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auctionslider : MonoBehaviour
{

    public void auctionupdate(float value)
    {
        AuctionManager.instance2.auctionmoney = value;
        AuctionManager.instance2.auctionmoneyrepresent.text = " Rs " + (value + AuctionManager.instance2.moneyholder).ToString();



    }
}
