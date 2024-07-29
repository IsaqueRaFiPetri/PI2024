using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance;
    private Queue<string> sentences;

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Image characterImage;
    public GameObject dialogueBox;

    private void Start()
    {
        sentences = new Queue<string>();
        instance = this;
    }

    public void StartDialogue(Character charac)
    {
        nameText.text = charac.nome;
        characterImage.sprite = charac.charcterImage;
        dialogueBox.SetActive(true);

        sentences.Clear();

        foreach (string sentence in charac.sentences) 
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.1f);
        }
    }

    void EndDialogue()
    {
        dialogueBox.SetActive(false);
        PlayerStats.instance.SetWalkingMode();
    }
}
//https://www.youtube.com/watch?v=_nRzoTzeyxU
//https://jogoscomcafe.wordpress.com/2021/04/08/tutorial-sistema-de-dialogo-estilo-jrpg-unity/