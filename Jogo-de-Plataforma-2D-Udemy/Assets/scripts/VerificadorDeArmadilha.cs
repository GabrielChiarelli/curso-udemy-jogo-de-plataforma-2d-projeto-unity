using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificadorDeArmadilha : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<PlataformaArmadilha>())
        {
            other.gameObject.GetComponent<PlataformaArmadilha>().RodarCoroutineDesligarPlataforma();
        }
    }
}
