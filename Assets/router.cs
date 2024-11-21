using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class router : MonoBehaviour
{
   
    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void about()
    {
        SceneManager.LoadScene("about");
    }
    public void play()
    {
        SceneManager.LoadScene("play");
    }




}
