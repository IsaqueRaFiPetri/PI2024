using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private GameObject _caixaDeDialogo;

    [SerializeField] private Image _avatarPersonagem;
    [SerializeField] private TextMeshProUGUI _nomePersonagem;
    [SerializeField] private TextMeshProUGUI _textoFala;

    private Conversa _conversaAtual;
    private int _indiceFalas;
    private Queue<string> _filaFalas;

    public void IniciarDialogo(Conversa conversa)
    {
        //Faz aparecer a caixa de di�logo
        _caixaDeDialogo.SetActive(true);

        //Inicializa a fila
        _filaFalas = new Queue<string>();

        _conversaAtual = conversa;
        _indiceFalas = 0;

        ProximaFala();
    }

    public void ProximaFala()
    {
        if (_filaFalas.Count == 0)
        {
            if (_indiceFalas < _conversaAtual.Falas.Length)
            {
                //Coloca a imagem do personagem na caixa de di�logo e arruma o tamanho
                _avatarPersonagem.sprite = _conversaAtual.Falas[_indiceFalas].Personagem.Expressoes[_conversaAtual.Falas[_indiceFalas].IdDaExpressao];
                _avatarPersonagem.SetNativeSize();

                //Coloca o nome do personagem na caixa de di�logo
                _nomePersonagem.text = _conversaAtual.Falas[_indiceFalas].Personagem.Nome;

                //Coloca todas as falas da express�o atual em uma fila
                foreach (string textoFala in _conversaAtual.Falas[_indiceFalas].TextoDasFalas)
                {
                    _filaFalas.Enqueue(textoFala);
                }

                _indiceFalas++;
            }
            else
            {
                //Faz sumir a caixa de di�logo
                _caixaDeDialogo.SetActive(false);
                return;
            }
        }

        //textoFala.text = _filaFalas.Dequeue();
    }
}
//https://jogoscomcafe.wordpress.com/2021/04/08/tutorial-sistema-de-dialogo-estilo-jrpg-unity/