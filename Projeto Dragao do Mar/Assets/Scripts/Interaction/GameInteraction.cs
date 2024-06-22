using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameInteraction : MonoBehaviour
{
    public GameObject painelInteration;
    public bool isColliding;
    public KeyCode interactionKey;

    private void Awake()
    {
        isColliding = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = true;

            if (isColliding)
            {
                painelInteration.SetActive(true);
            }
        } 
    }

    private void OnTriggerExit(Collider collision)
    {
        isColliding = false;
        painelInteration.SetActive(false);
    }
    public void Interact()
    {
        Input.GetKeyDown(interactionKey);
    }

}
