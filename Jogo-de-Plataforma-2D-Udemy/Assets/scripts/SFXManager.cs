using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;
    public AudioSource somDaColeta, somDeDano, somDoPulo;

    void Awake()
    {
        instance = this;
    }
}
