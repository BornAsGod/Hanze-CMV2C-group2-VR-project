using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAsk_UI_mannager : MonoBehaviour
{
    public Canvas canvas;
    private bool enable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = enable;
            enable = !enable;
        }
    }
}
