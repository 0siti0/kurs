using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FirstDialog : MonoBehaviour
{
    public int state;
    public Animator anim, anim1;
    public Dialogue dialogue;

    void Start()
    {
        if (!PlayerPrefs.HasKey("StateFirstDialog") || state == 1)
        {
            
            PlayerPrefs.SetInt("StateFirstDialog", 0);
            state = 0;
            anim.Play("DialogStart.DialogWindowUp");
            anim1.Play("Base.ImageDown");
            GameObject obj = GameObject.FindGameObjectWithTag("ImageDialog");
            FindObjectOfType<DialogManager>().StartDialogue(dialogue, obj,anim,anim1);
        }
        
    }

}
