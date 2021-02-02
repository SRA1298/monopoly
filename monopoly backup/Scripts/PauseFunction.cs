using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseFunction : MonoBehaviour
{
    public GameObject pausepanel;

    private void Awake()
    {
        pausepanel.SetActive(false);
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

    public void backTomainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
