using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hover : MonoBehaviour
{
    //bool of buttons of objects
    public bool isHome;
    public bool isUsedCars;
    public bool isBegginerEvents;
    public bool isChampionship;

    // animator for objects
    private Animator anim;

    public GameObject usedCarsPanel;


    void Start()
    {
        anim = GetComponent<Animator>();
        usedCarsPanel.SetActive(false);
    }

    void OnMouseEnter() 
    {
        anim.SetBool("isHovered", true);
    }
    void OnMouseExit() 
    {
        anim.SetBool("isHovered", false);
    }
    void OnMouseUpAsButton()
    {
        if(isHome == true)
        {
            SceneManager.LoadScene("Home");
        }
        else if (isBegginerEvents == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if(isUsedCars == true)
        {
            usedCarsPanel.SetActive(true);
        }
    }
    
}
