using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelCred;

    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }

    public void Creditos()
    {
        painelCred.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelCred.SetActive(false);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
