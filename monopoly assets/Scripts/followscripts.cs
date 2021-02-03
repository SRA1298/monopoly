using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followscripts : MonoBehaviour
{
    public static followscripts camerainstance;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    [HideInInspector]
    public int blocknumber = 0;

    [HideInInspector] public Animator anim;


    // Start is called before the first frame update
    void Awake()
    {
        makeinstance();

        anim = GetComponent<Animator>();
        
    }
    void makeinstance()
    {
        if(camerainstance == null)
        {
            camerainstance = this;
        }
    }


    public void Stoptheanimator()
    {
        this.GetComponent<Animator>().enabled = false;
    }
   

    public void onlinecameramovemnetforplayer1()
    {
        player1 = GameObject.Find("Blue(Clone)");
    }

    public void onlinecameramovemnetforplayer2()
    {
        player2 = GameObject.Find("Green(Clone)");
    }

    public void onlinecameramovemnetforplayer3()
    {
        player3 = GameObject.Find("Red(Clone)");
    }

    public void onlinecameramovemnetforplayer4()
    {
        player4 = GameObject.Find("Yellow(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        if(DiceManager.Diceinstance.cameracontrol == true)
        {
            StartCoroutine("playercamerahavetoawait");
        }
        
       

    }
    // this is use to move our camera for the main top view of the board
    public void cameraattopfunction(int i)
    {
        blocknumber = i;
        transform.position = new Vector3(-5f, 13.61f, -5f);
        transform.eulerAngles = new Vector3(90, -90, 0);
    }
    // in this function the camera is ajusted according to the player and the block on which the player is moving
    IEnumerator playercamerahavetoawait()
    {
        yield return new WaitForSeconds(2);
        if (DiceManager.Diceinstance.cameracontrol == true)
        {
            

            if (DiceManager.Diceinstance.playerturn == 1)
            {
                if (player1.transform.position.z < 2 && player1.transform.position.z > -11.5 && player1.transform.position.x > -1)
                {
                    transform.position = new Vector3(player1.transform.position.x + 2f, 1, player1.transform.position.z);
                    transform.eulerAngles = new Vector3(25, -90, 0);
                    player1.transform.eulerAngles = new Vector3(0, 180, 0);
                }
                if (player1.transform.position.x < 2 && player1.transform.position.x > -11.5f && player1.transform.position.z < -10)
                {
                    transform.position = new Vector3(player1.transform.position.x, 1, player1.transform.position.z - 1.7f);
                    transform.eulerAngles = new Vector3(25, 0, 0);
                    player1.transform.eulerAngles = new Vector3(0, 270, 0);
                }
                if (player1.transform.position.z < 2 && player1.transform.position.z > -11.5f && player1.transform.position.x < -10)
                {
                    transform.position = new Vector3(player1.transform.position.x - 2, 1, player1.transform.position.z);
                    transform.eulerAngles = new Vector3(25, 90, 0);
                    player1.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (player1.transform.position.x < 2 && player1.transform.position.x > -11.5f && player1.transform.position.z > -1)
                {
                    transform.position = new Vector3(player1.transform.position.x, 1, player1.transform.position.z + 2);
                    transform.eulerAngles = new Vector3(25, 180, 0);
                    player1.transform.eulerAngles = new Vector3(0, 90, 0);
                }


            }
            if (DiceManager.Diceinstance.playerturn == 2)
            {
                if (player2.transform.position.z < 2 && player2.transform.position.z > -11.5 && player2.transform.position.x > -1)
                {
                    transform.position = new Vector3(player2.transform.position.x + 2f, 1, player2.transform.position.z);
                    transform.eulerAngles = new Vector3(25, -90, 0);
                    player2.transform.eulerAngles = new Vector3(0, 180, 0);
                }
                if (player2.transform.position.x < 2 && player2.transform.position.x > -11.5f && player2.transform.position.z < -10)
                {
                    transform.position = new Vector3(player2.transform.position.x, 1, player2.transform.position.z - 1.7f);
                    transform.eulerAngles = new Vector3(25, 0, 0);
                    player2.transform.eulerAngles = new Vector3(0, 270, 0);
                }
                if (player2.transform.position.z < 2 && player2.transform.position.z > -11.5f && player2.transform.position.x < -10)
                {
                    transform.position = new Vector3(player2.transform.position.x - 2, 1, player2.transform.position.z);
                    transform.eulerAngles = new Vector3(25, 90, 0);
                    player2.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (player2.transform.position.x < 2 && player2.transform.position.x > -11.5f && player2.transform.position.z > -1)
                {
                    transform.position = new Vector3(player2.transform.position.x, 1, player2.transform.position.z + 2);
                    transform.eulerAngles = new Vector3(25, 180, 0);
                    player2.transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }

            if (DiceManager.Diceinstance.playerturn == 3)
            {
                if (player3.transform.position.z < 2 && player3.transform.position.z > -11.5 && player3.transform.position.x > -1)
                {
                    transform.position = new Vector3(player3.transform.position.x + 2f, 1, player3.transform.position.z);
                    transform.eulerAngles = new Vector3(25, -90, 0);
                    player3.transform.eulerAngles = new Vector3(0, 180, 0);
                }
                if (player3.transform.position.x < 2 && player3.transform.position.x > -11.5f && player3.transform.position.z < -10)
                {
                    transform.position = new Vector3(player3.transform.position.x, 1, player3.transform.position.z - 1.7f);
                    transform.eulerAngles = new Vector3(25, 0, 0);
                    player3.transform.eulerAngles = new Vector3(0, 270, 0);
                }
                if (player3.transform.position.z < 2 && player3.transform.position.z > -11.5f && player3.transform.position.x < -10)
                {
                    transform.position = new Vector3(player3.transform.position.x - 2, 1, player3.transform.position.z);
                    transform.eulerAngles = new Vector3(25, 90, 0);
                    player3.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (player3.transform.position.x < 2 && player3.transform.position.x > -11.5f && player3.transform.position.z > -1)
                {
                    transform.position = new Vector3(player3.transform.position.x, 1, player3.transform.position.z + 2);
                    transform.eulerAngles = new Vector3(25, 180, 0);
                    player3.transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }

            if (DiceManager.Diceinstance.playerturn == 4)
            {
                if (player4.transform.position.z < 2 && player4.transform.position.z > -11.5 && player4.transform.position.x > -1)
                {
                    transform.position = new Vector3(player4.transform.position.x + 2f, 1, player4.transform.position.z);
                    transform.eulerAngles = new Vector3(25, -90, 0);
                    player4.transform.eulerAngles = new Vector3(0, 180, 0);
                }
                if (player4.transform.position.x < 2 && player4.transform.position.x > -11.5f && player4.transform.position.z < -10)
                {
                    transform.position = new Vector3(player4.transform.position.x, 1, player4.transform.position.z - 1.7f);
                    transform.eulerAngles = new Vector3(25, 0, 0);
                    player4.transform.eulerAngles = new Vector3(0, 270, 0);
                }
                if (player4.transform.position.z < 2 && player4.transform.position.z > -11.5f && player4.transform.position.x < -10)
                {
                    transform.position = new Vector3(player4.transform.position.x - 2, 1, player4.transform.position.z);
                    transform.eulerAngles = new Vector3(25, 90, 0);
                    player4.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (player4.transform.position.x < 2 && player4.transform.position.x > -11.5f && player4.transform.position.z > -1)
                {
                    transform.position = new Vector3(player4.transform.position.x, 1, player4.transform.position.z + 2);
                    transform.eulerAngles = new Vector3(25, 180, 0);
                    player4.transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }
        }
    }
}
