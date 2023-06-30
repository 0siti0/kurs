using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartProject : MonoBehaviour
{
    public void Transition()
    {
        if (!PlayerPrefs.HasKey("playerx") && !PlayerPrefs.HasKey("playery"))
        {
            PlayerPrefs.SetFloat("playerx", (float)18.78);
            PlayerPrefs.SetFloat("playery", (float)2.774);
        }
        if(!PlayerPrefs.HasKey("Camera1") && !PlayerPrefs.HasKey("Camera2"))
        {
            PlayerPrefs.SetInt("Camera1", 1);
            PlayerPrefs.SetInt("Camera2", 0);
            PlayerPrefs.SetInt("Image1", 1);
            PlayerPrefs.SetInt("Image2", 0);

        }
        SceneManager.LoadScene("StartMenu");
    }
    public void Exit()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
