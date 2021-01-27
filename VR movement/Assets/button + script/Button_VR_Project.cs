using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_VR_Project : MonoBehaviour
{
    private bool enablle = true;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Hand")
        {
            //button go brrrr
        }
    }
}
