using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;

    public void PlayButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void CreditsButton()
    {
        if (creditsPanel.activeSelf)
        {
            creditsPanel.SetActive(false);
        }
        else
        {
            creditsPanel.SetActive(true);
        }
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
