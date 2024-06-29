using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VerifyDropdown : MonoBehaviour
{
    public TMP_Text correctAnswer;
    bool isSelected;
    public string correctAnswerLine;
   
    void Update()
    {
        if(correctAnswer) 
        {
            isSelected = true;
        }
        print(correctAnswer.text);
        print(isSelected);
    }
}
