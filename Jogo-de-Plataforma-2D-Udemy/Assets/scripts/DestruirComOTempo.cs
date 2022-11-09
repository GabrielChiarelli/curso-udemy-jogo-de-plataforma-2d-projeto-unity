using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComOTempo : MonoBehaviour
{
    public float tempoDeVida;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoDeVida);
    }
}
