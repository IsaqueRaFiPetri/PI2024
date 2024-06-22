using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPuzzleInteraction : GameInteraction
{
    public GameObject puzzlePainel;

    // Update is called once per frame
    void Update()
    {
        if(isColliding)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                painelInteration.SetActive(false);
                puzzlePainel.SetActive(true);
                PlayerStats.instance.SetUIingMode();
            }
        }
    }

    public void ClosePuzzle()
    {
        puzzlePainel.SetActive(false);
        PlayerStats.instance.SetWalkingMode();
    }
}
