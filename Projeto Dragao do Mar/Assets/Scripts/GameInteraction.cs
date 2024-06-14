using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInteraction : MonoBehaviour
{
    public GameObject painelInteração;

    private void OnTriggerEnter(Collider other)
    {
        painelInteração.SetActive(true); 
        //PlayerStats.instance.playerPos(transform.Rotate())
        
    }
    private void OnTriggerExit(Collider other)
    {
        painelInteração.SetActive(false);
    }
}
