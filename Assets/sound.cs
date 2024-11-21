using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public Slider musicslider;
    public Toggle Tog;
    private void Start()
    {
        GetComponent<AudioSource>().enabled = true;
        GetComponent<AudioSource>().Play();
        
    }
    public void Music()
    {
        if(Tog.isOn == false)
        {
            GetComponent<AudioSource>().enabled = false;
            GetComponent<AudioSource>().Stop();
        }
        else
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<AudioSource>().Play();
        }
    }
    public void MusicVolume()
    {
        GetComponent<AudioSource>().volume = musicslider.value;
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
   
}
