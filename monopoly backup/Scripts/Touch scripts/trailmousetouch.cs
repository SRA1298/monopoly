using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailmousetouch : MonoBehaviour
{
    public GameObject image;


    private void Awake()
    {
        image = GameObject.Find("trial image");
        image.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //   if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //    {
        //        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
        //        RaycastHit hit;

        //        if(Physics.Raycast(ray, out hit))
        //        {
        //            if (hit.collider != null)
        //            {
        //                image.SetActive(true);
        //                StartCoroutine("waitforimage");
        //            }
        //        }


        //    }

#if UNITY_EDITOR

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform != null && GameObject.FindGameObjectWithTag("Tile 1"))
                    {

                        image.SetActive(true);
                        StartCoroutine("waitforimage");


                    }
                }

            }
        
#endif

    }

   

    IEnumerator waitforimage()
    {
        yield return new WaitForSeconds(2);
        image.SetActive(false);
    }

}
