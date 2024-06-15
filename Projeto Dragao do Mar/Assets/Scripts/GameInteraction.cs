using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameInteraction : MonoBehaviour
{
    public GameObject painelInteração;
    public bool isColliding;
    public KeyCode interactionKey;

    private void Awake()
    {
        isColliding = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isColliding = true;
        if(isColliding)
        {
            painelInteração.SetActive(true);
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        isColliding = false;
        painelInteração.SetActive(false);
    }
    public void Interact()
    {
        if (isColliding)
        {
            //Input.GetButtonDown(KeyCode.E);
        }
    }

}
