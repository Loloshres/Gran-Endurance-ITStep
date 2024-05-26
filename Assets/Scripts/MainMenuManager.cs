using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public Animator fade;

    void Start()
    {
        optionsPanel.SetActive(false);
    }
    
    public void OnStartButtonDown()
    {
        SceneManager.LoadScene("Menu");
        fade.SetBool("IsFadeOut", true);
    }

    public void OnExitButtonDown()
    {
        Application.Quit();
    }

    public void OnOptionsButtonDown()
    {
        optionsPanel.SetActive(true);
    }

    public void OnExitOptionsButtonDown()
    {
        optionsPanel.SetActive(false);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
