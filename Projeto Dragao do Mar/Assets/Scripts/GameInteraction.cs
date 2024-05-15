using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInteraction : MonoBehaviour
{
    public GameObject painelInteração;

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {painelInteração.SetActive(true);
        
    }
    private void OnTriggerExit(Collider other)
    {
        painelInteração.SetActive(false);
    }
}
