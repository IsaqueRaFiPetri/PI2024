using UnityEngine;
using UnityEngine.UI;

public class Phases : MonoBehaviour
{
    public Button[] buttons;

    private void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i + 1 > PlayerPrefs.GetInt("faseCompleta"))
            {
                buttons[i].interactable = false;
            }
        }
    }
}