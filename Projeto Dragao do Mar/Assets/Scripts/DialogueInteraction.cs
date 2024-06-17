using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteraction : GameInteraction
{
    public GameObject dialogueCanvas;
    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            dialogueCanvas.SetActive(true);
        }
    }

    public void LastSpeak()
    {
        dialogueCanvas.SetActive(false);
    }
}
