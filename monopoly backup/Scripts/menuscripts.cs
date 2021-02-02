using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscripts : MonoBehaviour
{
    public static menuscripts menuinstance;
    public GameObject mainmenupanel;
    public GameObject on_offlinepanel;
    public GameObject rulespanel;
    public GameObject online_rulespanel;
    public GameObject CreateJoinPanel;
    [HideInInspector]public bool forjoinmoneyslider = false;
    [HideInInspector]
    public bool istimer = false;
    [HideInInspector] public bool gameisonline = false;
    private void Awake()
    {
        makeinstance();
        mainmenupanel.transform.gameObject.SetActive(true);
        on_offlinepanel.transform.gameObject.SetActive(false);
        rulespanel.transform.gameObject.SetActive(false);
        online_rulespanel.transform.gameObject.SetActive(false);
        CreateJoinPanel.transform.gameObject.SetActive(false);
    }

    void makeinstance()
    {
        if(menuinstance == null)
        {
            menuinstance = this;
        }

    }
    public void startbuttfunction()
    {
        //GetComponent<AudioSource>().Play();
        mainmenupanel.transform.gameObject.SetActive(false);
        on_offlinepanel.transform.gameObject.SetActive(true);

    }

    public void Quitbuttfunction()
    {

        Application.Quit();

    }

    public void onlinebutton()
    {
        gameisonline = true;
        //print("online button is pressed");
        on_offlinepanel.transform.gameObject.SetActive(false);
        CreateJoinPanel.transform.gameObject.SetActive(true);
        // SceneManager.LoadScene("Get Username");
        
    }

    public void offlinebutton()
    {
        gameisonline = false;
        on_offlinepanel.transform.gameObject.SetActive(false);
        rulespanel.transform.gameObject.SetActive(true);
    }

    public void backbuttononline_offline()
    {
        mainmenupanel.transform.gameObject.SetActive(true);
        on_offlinepanel.transform.gameObject.SetActive(false);
    }

    public void rulessetbackbuttonoffline()
    {
        on_offlinepanel.transform.gameObject.SetActive(true);
        rulespanel.transform.gameObject.SetActive(false);
    }

    public void createroombackbutton()
    {
        on_offlinepanel.transform.gameObject.SetActive(true);
        CreateJoinPanel.transform.gameObject.SetActive(false);
    }

    public void rulessetbackonline()
    {
        CreateJoinPanel.transform.gameObject.SetActive(true);
        online_rulespanel.transform.gameObject.SetActive(false);
    }
    
    public void timerbutton()
    {
        istimer = true;
        SceneManager.LoadScene("UI - Copy");
    }
    public void classicbutton()
    {
       
        SceneManager.LoadScene("Classic");
    }

    public void onlinetimerbuttton()
    {
        istimer = true;
        SceneManager.LoadScene("Get Username");
        //SceneManager.LoadScene("online UI - Copy 1");
    }

    public void onlineclassicbutton()
    {
        SceneManager.LoadScene("Get Username");
        // SceneManager.LoadScene("online Classic 1");
    }

    public void createRoomFunction()
    {
        CreateJoinPanel.transform.gameObject.SetActive(false);
        online_rulespanel.transform.gameObject.SetActive(true);
    }
    
    public void JoinRoomFunction()
    {
        forjoinmoneyslider = true;
        SceneManager.LoadScene("Get Username");
    }

   
}
