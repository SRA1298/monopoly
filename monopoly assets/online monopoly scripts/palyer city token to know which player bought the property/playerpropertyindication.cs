using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpropertyindication : Photon.MonoBehaviour
{

    /*this scripts is developed to assign the property tag on the perticular city and made for the online version of the game */



    public static playerpropertyindication playerpropertyinstance;

    public PhotonView photonview;

    [HideInInspector]
    public GameObject[] playersymbolforproperty = new GameObject[41];

    private void Start()
    {
        makeinstance();

    }


    void makeinstance()
    {
        if (playerpropertyinstance == null)
        {
            playerpropertyinstance = this;
        }
       
    }


    // this function is created to show which player have bought which city
    public void playersymbol(int r)
    {
        if (photonview.isMine)
        {
            if (DiceManager.Diceinstance.playerturn == 1)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[0].name, new Vector3( 0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (DiceManager.Diceinstance.playerturn == 2)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[1].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (DiceManager.Diceinstance.playerturn == 3)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[2].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (DiceManager.Diceinstance.playerturn == 4)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[3].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }
        }

       

    }

    // THIS FUNCTION IS USED AFTER THE AUCTION BUTTON IS SELECTED
    public void Auctionplayersymbol(int r, int playernumber)
    {
        if (photonview.isMine)
         {
            if (playernumber == 1)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[0].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (playernumber == 2)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[1].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (playernumber == 3)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[2].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

            if (playernumber == 4)
            {
                playersymbolforproperty[r] = PhotonNetwork.Instantiate(PanelManager.instance.playerSymbol[3].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
                if (r < 10)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
                }
                if (r > 10 && r < 20)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
                }
                if (r > 20 && r < 30)
                {
                    playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

                }
                if (r > 30 && r < 40)
                {
                    playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
                    playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
                }
            }

        }
       
    }
}

