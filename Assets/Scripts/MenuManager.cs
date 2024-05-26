using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator fade;

    void Start()
    {
        fade = GetComponent<Animator>();
    }
    public void OnExitToMainMenuButtonDown()
    {
        SceneManager.LoadScene("MainMenu");
        fade.SetBool("IsFadeOut", true);
    }
}
