using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseFunction : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject soundonoffpanel;
    public GameObject background;

    private void Awake()
    {
        pausepanel.SetActive(false);
        soundonoffpanel.SetActive(false);
    }

    public void PauseButton()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ResumeButton()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Soundonoff()
    {
        soundonoffpanel.SetActive(true);
        pausepanel.SetActive(false);
    }

    public void backTomainmenu()
    {
        Time.timeScale = 1f;
        gameover.gameoverinstance.quitpanel.transform.gameObject.SetActive(true);
        pausepanel.SetActive(false);
    }

    public void soundonbutton()
    {
        Time.timeScale = 1f;
        background.GetComponent<AudioSource>().enabled = true;
        soundonoffpanel.SetActive(false);
    }

    public void soundoffbutton()
    {
        Time.timeScale = 1f;
        background.GetComponent<AudioSource>().enabled = false;
        soundonoffpanel.SetActive(false);
    }
}
