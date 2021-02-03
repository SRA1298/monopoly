using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racastdebugging : MonoBehaviour
{
    public static racastdebugging rayinstance;

    [HideInInspector]
    public bool clickcityrepresentation = true;

    public GameObject cityrepresentpanel;

    public GameObject[] cityimage;

    // Start is called before the first frame update
    void Awake()
    {

        cityimage[0] = GameObject.Find("trial");
        cityimage[0].SetActive(false);

        cityimage[1] = GameObject.Find("City (1)");
        cityimage[1].SetActive(false);

        cityimage[2] = GameObject.Find("City (3)");
        cityimage[2].SetActive(false);

        cityimage[3] = GameObject.Find("station 1");
        cityimage[3].SetActive(false);

        cityimage[4] = GameObject.Find("City (6)");
        cityimage[4].SetActive(false);

        cityimage[5] = GameObject.Find("City (8)");
        cityimage[5].SetActive(false);

        cityimage[6] = GameObject.Find("City (9)");
        cityimage[6].SetActive(false);

        cityimage[7] = GameObject.Find("City (11)");
        cityimage[7].SetActive(false);

        cityimage[8] = GameObject.Find("City (12)");
        cityimage[8].SetActive(false);

        cityimage[9] = GameObject.Find("City (13)");
        cityimage[9].SetActive(false);

        cityimage[10] = GameObject.Find("City (14)");
        cityimage[10].SetActive(false);

        cityimage[11] = GameObject.Find("station 2");
        cityimage[11].SetActive(false);

        cityimage[12] = GameObject.Find("City (16)");
        cityimage[12].SetActive(false);

        cityimage[13] = GameObject.Find("City (18)");
        cityimage[13].SetActive(false);

        cityimage[14] = GameObject.Find("City (19)");
        cityimage[14].SetActive(false);

        cityimage[15] = GameObject.Find("City (21)");
        cityimage[15].SetActive(false);

        cityimage[16] = GameObject.Find("City (23)");
        cityimage[16].SetActive(false);

        cityimage[17] = GameObject.Find("City (24)");
        cityimage[17].SetActive(false);

        cityimage[18] = GameObject.Find("station 3");
        cityimage[18].SetActive(false);

        cityimage[19] = GameObject.Find("City (26)");
        cityimage[19].SetActive(false);

        cityimage[20] = GameObject.Find("City (27)");
        cityimage[20].SetActive(false);

        cityimage[21] = GameObject.Find("City (28)");
        cityimage[21].SetActive(false);

        cityimage[22] = GameObject.Find("City (29)");
        cityimage[22].SetActive(false);

        cityimage[23] = GameObject.Find("City (31)");
        cityimage[23].SetActive(false);

        cityimage[24] = GameObject.Find("City (32)");
        cityimage[24].SetActive(false);

        cityimage[25] = GameObject.Find("City (34)");
        cityimage[25].SetActive(false);

        cityimage[26] = GameObject.Find("station 4");
        cityimage[26].SetActive(false);

        cityimage[27] = GameObject.Find("City (37)");
        cityimage[27].SetActive(false);

        cityimage[28] = GameObject.Find("City (39)");
        cityimage[28].SetActive(false);


        makeinstance();
        
        cityrepresentpanel.transform.gameObject.SetActive(false);




    }

    void makeinstance()
    {
        if(rayinstance == null)
        {
            rayinstance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 200.0f))
            {
                if (clickcityrepresentation == true) //this help to stop the extra click activity
                {
                    Printname(hit.transform.gameObject);
                }
                else
                {
                    //print("no operation for object touch panel");
                }
            }
        }


    }

    void Printname(GameObject go)
    {
        //print(go.name);
        cityrepresentpanel.transform.gameObject.SetActive(true);
        if (go.name == "Tile 1")
        {
            cityimage[1].SetActive(true);
           
        }
        if (go.name == "Tile 3")
        {
            cityimage[2].SetActive(true);

        }
        if (go.name == "Tile 5")
        {
            cityimage[3].SetActive(true);

        }
        if (go.name == "Tile 6")
        {
            cityimage[4].SetActive(true);

        }
        if (go.name == "Tile 8")
        {
            cityimage[5].SetActive(true);

        }
        if (go.name == "Tile 9")
        {
            cityimage[6].SetActive(true);

        }
        if (go.name == "Tile 11")
        {
            cityimage[7].SetActive(true);

        }
        if (go.name == "Tile 12")
        {
            cityimage[8].SetActive(true);

        }
        if (go.name == "Tile 13")
        {
            cityimage[9].SetActive(true);

        }
        if (go.name == "Tile 14")
        {
            cityimage[10].SetActive(true);

        }
        if (go.name == "Tile 15")
        {
            cityimage[11].SetActive(true);

        }
        if (go.name == "Tile 16")
        {
            cityimage[12].SetActive(true);

        }
        if (go.name == "Tile 18")
        {
            cityimage[13].SetActive(true);

        }
        if (go.name == "Tile 19")
        {
            cityimage[14].SetActive(true);

        }
        if (go.name == "Tile 21")
        {
            cityimage[15].SetActive(true);

        }
        if (go.name == "Tile 23")
        {
            cityimage[16].SetActive(true);

        }
        if (go.name == "Tile 24")
        {
            cityimage[17].SetActive(true);

        }
        if (go.name == "Tile 25")
        {
            cityimage[18].SetActive(true);

        }
        if (go.name == "Tile 26")
        {
            cityimage[19].SetActive(true);

        }
        if (go.name == "Tile 27")
        {
            cityimage[20].SetActive(true);

        }
        if (go.name == "Tile 28")
        {
            cityimage[21].SetActive(true);

        }
        if (go.name == "Tile 29")
        {
            cityimage[22].SetActive(true);

        }
        if (go.name == "Tile 31")
        {
            cityimage[23].SetActive(true);

        }
        if (go.name == "Tile 32")
        {
            cityimage[24].SetActive(true);

        }
        if (go.name == "Tile 34")
        {
            cityimage[25].SetActive(true);

        }
        if (go.name == "Tile 35")
        {
            cityimage[26].SetActive(true);

        }
        if (go.name == "Tile 37")
        {
            cityimage[27].SetActive(true);

        }
        if (go.name == "Tile 39")
        {
            cityimage[28].SetActive(true);

        }
    
        StartCoroutine("showthecitytouchpanelfor");
    }
    
    IEnumerator showthecitytouchpanelfor()
    {
        yield return new WaitForSeconds(2.5f);
        for(int i = 1; i <= 28; i++)
        {
            cityimage[i].SetActive(false);
        }

        cityrepresentpanel.transform.gameObject.SetActive(false);
    }
}
