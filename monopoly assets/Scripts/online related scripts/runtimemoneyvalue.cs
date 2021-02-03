using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runtimemoneyvalue : MonoBehaviour
{
    public Text playermoney1;
    public Text playermoney2;
    public Text playermoney3;
    public Text playermoney4;

    public void Update()
    {

        //playermoney1.text = playermoney1.text;
        //playermoney2.text = playermoney2.text;
        //playermoney3.text = playermoney3.text;
        //playermoney4.text = playermoney4.text;
        onlinecorrection.onlinecorrectioninstance.playername1.text = onlinecorrection.onlinecorrectioninstance.playername1.text;
        onlinecorrection.onlinecorrectioninstance.playername2.text = onlinecorrection.onlinecorrectioninstance.playername2.text;
        onlinecorrection.onlinecorrectioninstance.playername3.text = onlinecorrection.onlinecorrectioninstance.playername3.text;
        onlinecorrection.onlinecorrectioninstance.playername4.text = onlinecorrection.onlinecorrectioninstance.playername4.text;

    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(playermoney1.text);
            stream.SendNext(playermoney2.text);
            stream.SendNext(playermoney3.text);
            stream.SendNext(playermoney4.text);
            

        }
        else if (stream.isReading)
        {
            playermoney1.text = (string)stream.ReceiveNext();
            playermoney2.text = (string)stream.ReceiveNext();
            playermoney3.text = (string)stream.ReceiveNext();
            playermoney4.text = (string)stream.ReceiveNext();
            

        }
    }

}
