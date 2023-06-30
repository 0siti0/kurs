using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private string[] rows;
    private int idrowended;
    private Dialogue dialogue1;
    private Animator anim, anim1;

    public void StartDialogue(Dialogue dialogue, GameObject obj, Animator anim, Animator anim1)
    {
        dialogue1 = dialogue;
        if (File.Exists(Directory.GetCurrentDirectory() + "\\Assets\\Dialogue\\" + dialogue.namedialog + ".txt"))
        {
            this.anim = anim;
            this.anim1 = anim1;
            Image img = obj.GetComponent<Image>();
            img.sprite = dialogue.image;
            rows = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Assets\\Dialogue\\" + dialogue.namedialog + ".txt");
            string paragraph = "";
            idrowended = 0;
            for (int n = 0; n < 5; n++)
            {
                paragraph += rows[n];
                idrowended++;
            }
            dialogue.text.text = paragraph;
        }


    }

    public void NextDialogue()
    {
        string paragraph = "";
        int k = 0;
        if (idrowended < rows.Length)
        {
            if (idrowended + 5 < rows.Length)
            {
                for (int n = idrowended; n < idrowended + 5; n++)
                {
                    paragraph += rows[n];
                    k++;
                }
            }
            else
            {
                for (int n = idrowended; n < idrowended + (rows.Length - idrowended); n++)
                {
                    paragraph += rows[n];
                    k++;
                }
            }
        }
        else
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

        }
        idrowended += k;
        dialogue1.text.text = paragraph;


    }
}

   
