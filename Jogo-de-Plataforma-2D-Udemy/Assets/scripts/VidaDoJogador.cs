using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoJogador : MonoBehaviour
{
    [Header("Referências")]
    public GameObject efeitoDeExplosao;
    private Rigidbody2D oRigidbody2D;
    private Animator oAnimator;

    [Header("Valores")]
    public float tempoParaDestruirOJogador;

    void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarJogador()
    {
        SFXManager.instance.somDeDano.Play();
        FindObjectOfType<MovimentoDoJogador>().jogadorEstaVivo = false;
        //oRigidbody2D.velocity = new Vector2(0f, 0f);
        oRigidbody2D.velocity = Vector2.zero;
        oAnimator.Play("jogador-levando-dano");

        StartCoroutine(DestruirJogador());
    }

    private IEnumerator DestruirJogador()
    {
        yield return new WaitForSeconds(tempoParaDestruirOJogador);
        FindObjectOfType<GameManager>().GameOver();
        Instantiate(efeitoDeExplosao, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
