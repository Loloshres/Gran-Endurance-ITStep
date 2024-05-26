using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipVideo : MonoBehaviour
{
    public int waitTime;
    void Start()
    {
        StartCoroutine(WaitForLevel());
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("MainMenu");
        }
   }

   IEnumerator WaitForLevel()
   {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("MainMenu");
   }
}
