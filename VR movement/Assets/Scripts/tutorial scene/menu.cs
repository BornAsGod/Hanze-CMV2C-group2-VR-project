using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
