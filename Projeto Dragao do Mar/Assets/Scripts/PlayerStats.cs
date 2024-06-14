using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    public Transform playerPos;

    void Start()
    {
        instance = this;
        playerPos = transform;
    }

    void Update()
    {
        
    }
}
