using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDoJogo : MonoBehaviour
{
    public GameObject painelDoMenuInicial, painelDaTelaDeCreditos;

    public string nomeDaPrimeiraFase;

    public void CarregarJogo()
    {
        SceneManager.LoadScene(nomeDaPrimeiraFase);
    }

    public void AtivarPainelDoMenuInicial()
    {
        painelDaTelaDeCreditos.SetActive(false);
        painelDoMenuInicial.SetActive(true);
    }

    public void AtivarPainelDaTelaDeCreditos()
    {
        painelDoMenuInicial.SetActive(false);
        painelDaTelaDeCreditos.SetActive(true);
    }

    public void SairDoJogo()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
