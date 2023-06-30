using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transitionCamera : MonoBehaviour
{
    public new Camera camera;
    public GameObject image;
    public Camera camera2;
    public GameObject image2;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (camera.enabled)
        {
            camera.enabled = false;
            image.SetActive(false);
            camera2.enabled = true;
            image2.SetActive(true);
            PlayerPrefs.SetInt("Image1", 0);
            PlayerPrefs.SetInt("Image2", 1);
            PlayerPrefs.SetInt("Camera1", 0);
            PlayerPrefs.SetInt("Camera2", 1);
        }
        else if (camera2.enabled)
        {
            camera2.enabled = false;
            image2.SetActive(false);
            camera.enabled = true;
            image.SetActive(true);
            PlayerPrefs.SetInt("Image1", 1);
            PlayerPrefs.SetInt("Image2", 0);
            PlayerPrefs.SetInt("Camera1", 1);
            PlayerPrefs.SetInt("Camera2", 0);
        }
    }
}
