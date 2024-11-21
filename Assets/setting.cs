using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public GameObject pancel;
    private bool isclick = false;
    void playRenwu(bool isnotclick)
    {
        pancel.gameObject.SetActive(isnotclick);

    }
    public void Onclickbutton()
    {
        if(isclick==false)
        {
            isclick = true;
            playRenwu(true);
        }
        else
        {
            isclick = false;
            playRenwu(false);
        }
    }
}
