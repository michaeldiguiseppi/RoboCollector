using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ToggleSettings()
    {
        if (mainMenu.activeSelf != false)
        {
            mainMenu.SetActive(false);
            settingsMenu.SetActive(true);
        } else
        {
            mainMenu.SetActive(true);
            settingsMenu.SetActive(false);
        }   
    }
}
