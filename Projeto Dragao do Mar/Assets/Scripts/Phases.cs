using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phases : MonoBehaviour
{
    public Button[] botões;

    private void Update()
    {
        for (int i = 0; i < botões.Length; i++)
        {
            if (i + 1 > PlayerPrefs.GetInt("faseCompleta"))
            {
                botões[i].interactable = false;
            }
        }
    }
}