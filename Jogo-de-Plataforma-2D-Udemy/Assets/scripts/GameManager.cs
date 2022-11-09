using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nomeDoMenuInicial;

    public string nomeDaProximaFase;
    public float tempoParaRecarregarFase;
    public float tempoParaCarregarNovaFase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            VoltarAoMenu();
        }
    }

    private void VoltarAoMenu()
    {
        SceneManager.LoadScene(nomeDoMenuInicial);
    }

    public void GameOver()
    {
        RodarCoroutineRecarregarFase();
    }

    public void RodarCoroutineRecarregarFase()
    {
        StartCoroutine(RecarregarFase());
    }

    private IEnumerator RecarregarFase()
    {
        yield return new WaitForSeconds(tempoParaRecarregarFase);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RodarCoroutinePassarDeFase()
    {
        StartCoroutine(PassarDeFase());
    }

    private IEnumerator PassarDeFase()
    {
        yield return new WaitForSeconds(tempoParaCarregarNovaFase);
        SceneManager.LoadScene(nomeDaProximaFase);
    }
}
