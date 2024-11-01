using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{   
    [SerializeField] GameObject MenuInicial;
    [SerializeField] GameObject opcoes;
    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }

    public void AbrirOpcoes()
    {
        MenuInicial.SetActive(false);
        opcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        opcoes.SetActive(false);
        MenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

}
