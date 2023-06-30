using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogAnimator : MonoBehaviour
{


    public Animator anim, anim1;
    public DialogManager DM;
    public Dialogue dialogue;
    private bool touch = false;

    public void OnTriggerStay2D(Collider2D collider)
    {

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyUp(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("Camera1") == 1)
            {
                anim.Play("DialogStart.DialogWindowUp");
                anim1.Play("Base.ImageDown");
            }
            else if (PlayerPrefs.GetInt("Camera2") == 1)
            {
                anim.Play("Base Layer.DialogWindowUp");
                anim1.Play("Base Layer.ImageDown1");
            }

            GameObject obj = GameObject.FindGameObjectWithTag("ImageDialog");
            FindObjectOfType<DialogManager>().StartDialogue(dialogue, obj, anim, anim1);
            touch = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        if (touch)
        {
            if (PlayerPrefs.GetInt("Camera1") == 1)
            {
                anim.Play("DialogStart.DialogWindowDown");
                anim1.Play("Base.ImageUp");
            }
            else if (PlayerPrefs.GetInt("Camera2") == 1)
            {
                anim.Play("Base Layer.DialogWindowDown");
                anim1.Play("Base Layer.ImageUp1");
            }
            touch = false;
        }
    }
}
