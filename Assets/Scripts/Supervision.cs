using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supervision : MonoBehaviour
{
    public Camera camera1, camera2;
    public GameObject image1, image2;
    void Start()
    {

        if ((PlayerPrefs.GetInt("Camera1") == 1) && (PlayerPrefs.GetInt("Camera2") == 0))
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }
        else if ((PlayerPrefs.GetInt("Camera1") == 0) && (PlayerPrefs.GetInt("Camera2") == 1))
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        if ((PlayerPrefs.GetInt("Image1") == 1) && (PlayerPrefs.GetInt("Image2") == 0))
        {
            image1.SetActive(true);
            image2.SetActive(false);
        }
        else if ((PlayerPrefs.GetInt("Image1") == 0) && (PlayerPrefs.GetInt("Image2") == 1))
        {
            Debug.Log("Image2.. Active");
            image1.SetActive(false);
            image2.SetActive(true);
        }
    }
}
