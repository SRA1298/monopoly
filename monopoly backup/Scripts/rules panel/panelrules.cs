using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelrules : MonoBehaviour
{
    public GameObject welcomepanel;

    public void welcomepanelok()
    {
        welcomepanel.transform.gameObject.SetActive(false);

        followscripts.camerainstance.anim.SetBool("boardview", true);
    }


}
