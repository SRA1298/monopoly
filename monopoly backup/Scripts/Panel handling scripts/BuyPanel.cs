using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPanel : MonoBehaviour
{
    public static BuyPanel instance1;


    public GameObject Buypanel; 

    [SerializeField]
    private GameObject[] Buyimage;

    [SerializeField]
    private GameObject text2;

    public GameObject tradingrulepanel;
    public GameObject mortgagerulepanel;
    public GameObject sellhouserulepanel;

    bool rulepanel;
    void Awake()
    {
       

        Buyimage[0] = GameObject.Find("Buy Image");
        Buyimage[0].SetActive(false);

        Buyimage[1] = GameObject.Find("Buy Image (1)");
        Buyimage[1].SetActive(false);

        Buyimage[2] = GameObject.Find("Buy Image (2)");
        Buyimage[2].SetActive(false);

        Buyimage[3] = GameObject.Find("Buy Image (3)");
        Buyimage[3].SetActive(false);

        Buyimage[4] = GameObject.Find("Buy Image (4)");
        Buyimage[4].SetActive(false);

        Buyimage[5] = GameObject.Find("Buy Image (5)");
        Buyimage[5].SetActive(false);

        Buyimage[6] = GameObject.Find("Buy Image (6)");
        Buyimage[6].SetActive(false);

        Buyimage[7] = GameObject.Find("Buy Image (7)");
        Buyimage[7].SetActive(false);

        Buyimage[8] = GameObject.Find("Buy Image (8)");
        Buyimage[8].SetActive(false);

        Buyimage[9] = GameObject.Find("Buy Image (9)");
        Buyimage[9].SetActive(false);

        Buyimage[10] = GameObject.Find("Buy Image (10)");
        Buyimage[10].SetActive(false);

        Buyimage[11] = GameObject.Find("Buy Image (11)");
        Buyimage[11].SetActive(false);

        Buyimage[12] = GameObject.Find("Buy Image (12)");
        Buyimage[12].SetActive(false);

        Buyimage[13] = GameObject.Find("Buy Image (13)");
        Buyimage[13].SetActive(false);

        Buyimage[14] = GameObject.Find("Buy Image (14)");
        Buyimage[14].SetActive(false);

        Buyimage[15] = GameObject.Find("Buy Image (15)");
        Buyimage[15].SetActive(false);

        Buyimage[16] = GameObject.Find("Buy Image (16)");
        Buyimage[16].SetActive(false);

        Buyimage[17] = GameObject.Find("Buy Image (17)");
        Buyimage[17].SetActive(false);

        Buyimage[18] = GameObject.Find("Buy Image (18)");
        Buyimage[18].SetActive(false);

        Buyimage[19] = GameObject.Find("Buy Image (19)");
        Buyimage[19].SetActive(false);

        Buyimage[20] = GameObject.Find("Buy Image (20)");
        Buyimage[20].SetActive(false);

        Buyimage[21] = GameObject.Find("Buy Image (21)");
        Buyimage[21].SetActive(false);

        Buyimage[22] = GameObject.Find("Buy Image (22)");
        Buyimage[22].SetActive(false);

        Buyimage[23] = GameObject.Find("Buy Image (23)");
        Buyimage[23].SetActive(false);

        Buyimage[24] = GameObject.Find("Buy Image (24)");
        Buyimage[24].SetActive(false);

        Buyimage[25] = GameObject.Find("Buy Image (25)");
        Buyimage[25].SetActive(false);

        Buyimage[26] = GameObject.Find("Buy Image (26)");
        Buyimage[26].SetActive(false);

        Buyimage[27] = GameObject.Find("Buy Image (27)");
        Buyimage[27].SetActive(false);

        Buyimage[28] = GameObject.Find("Buy Image (28)");
        Buyimage[28].SetActive(false);

        Buyimage[29] = GameObject.Find("Buy Image (29)");
        Buyimage[29].SetActive(false);

        Buyimage[30] = GameObject.Find("Buy Image (30)");
        Buyimage[30].SetActive(false);

        Buyimage[31] = GameObject.Find("Buy Image (31)");
        Buyimage[31].SetActive(false);

        Buyimage[32] = GameObject.Find("Buy Image (32)");
        Buyimage[32].SetActive(false);

        Buyimage[33] = GameObject.Find("Buy Image (33)");
        Buyimage[33].SetActive(false);

        Buyimage[34] = GameObject.Find("Buy Image (34)");
        Buyimage[34].SetActive(false);

        Buyimage[35] = GameObject.Find("Buy Image (35)");
        Buyimage[35].SetActive(false);

        Buyimage[36] = GameObject.Find("Buy Image (36)");
        Buyimage[36].SetActive(false);

        Buyimage[37] = GameObject.Find("Buy Image (37)");
        Buyimage[37].SetActive(false);

        Buyimage[38] = GameObject.Find("Buy Image (38)");
        Buyimage[38].SetActive(false);

        Buyimage[39] = GameObject.Find("Buy Image (39)");
        Buyimage[39].SetActive(false);

        Buyimage[40] = GameObject.Find("Buy Image (40)");
        Buyimage[40].SetActive(false);

        text2 = GameObject.Find("BuyText");
        text2.SetActive(false);

        Buypanel.transform.gameObject.SetActive(false);
        tradingrulepanel.transform.gameObject.SetActive(false);
        mortgagerulepanel.transform.gameObject.SetActive(false);
        sellhouserulepanel.transform.gameObject.SetActive(false);
        rulepanel = true;
    }


    private void Start()
    {
        makeInstance1();
    }

    void makeInstance1()
    {
        if (instance1 == null)
        {
            instance1 = this;
        }
    }

    public void ShowBuypanelImage(int i)
    {
        Buypanel.transform.gameObject.SetActive(true);
        
        text2.SetActive(true);
        Buyimage[i].SetActive(true);
        StartCoroutine(waitforsec(i));

    }

    IEnumerator waitforsec(int j)
    {
        yield return new WaitForSeconds(2f);
        Buyimage[j].SetActive(false);
        text2.SetActive(false);
        Buypanel.transform.gameObject.SetActive(false);
        if (rulepanel == true)
        {
            rulepanel = false;
            tradingrulepanel.transform.gameObject.SetActive(true);

        }


    }

    public void tradingruleoffbutton()
    {
        tradingrulepanel.transform.gameObject.SetActive(false);
        mortgagerulepanel.transform.gameObject.SetActive(true);
    }

    public void mortgageruleoffbutton()
    {
        mortgagerulepanel.transform.gameObject.SetActive(false);
        sellhouserulepanel.transform.gameObject.SetActive(true);
    }

    public void sellhouseruleoffbutton()
    {
        sellhouserulepanel.transform.gameObject.SetActive(false);
    }



}
