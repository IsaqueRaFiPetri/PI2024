using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteraction : GameInteraction
{
    public GameObject dialogueCanvas;
    
    public void Update()
    {
        if (isColliding)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                painelInteration.SetActive(false);
                dialogueCanvas.SetActive(true);
                PlayerStats.instance.SetUIingMode();
            }
        }
    }

    public void LastSpeak()
    {
        dialogueCanvas.SetActive(false);
        PlayerStats.instance.SetWalkingMode();
    }
}
