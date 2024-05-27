using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManag : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelCred;

    public void Jogar()
    {
        SceneManager.LoadScene("GameScene");
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
