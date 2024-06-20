using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum PlayerModes
{
    Walking, UIing
}

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    PlayerModes modes;
    FirstPersonController controller;

    public UnityEvent OnPause, OnUnpause;

    void Awake()
    {
        instance = this;
        controller = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        switch (modes)
        {
            case PlayerModes.Walking:
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                controller.enabled = true;
                break;
            case PlayerModes.UIing:
                controller.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                break;
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                modes = PlayerModes.Walking;
                OnUnpause.Invoke();
            }
            else
            {
                Time.timeScale = 0;
                modes = PlayerModes.UIing;
                OnPause.Invoke();
            }
        }
    }

    public void SetPause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
