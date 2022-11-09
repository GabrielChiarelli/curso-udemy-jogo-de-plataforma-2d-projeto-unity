using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoLetal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<VidaDoJogador>().MachucarJogador();
        }
    }
}
