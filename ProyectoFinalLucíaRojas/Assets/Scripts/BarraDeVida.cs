using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    
    public Image barraDeVida;
    public float vidaMaxima = 100f;
    private float vidaActual;

    void Start()
    {
        vidaActual = vidaMaxima;
        ActualizarBarraDeVida();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemigo"))
        {
            Debug.Log("Colisión con enemigo");
            vidaActual -= 50f;
            ActualizarBarraDeVida();
            Destroy(collision.gameObject); // Destruir el objeto enemigo
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CruzVida"))
        {
            Debug.Log("Colisión con CruzVida");
            vidaActual += 100f;
            if (vidaActual > vidaMaxima)
                vidaActual = vidaMaxima;
            ActualizarBarraDeVida();
            Destroy(other.gameObject); // Destruir el objeto CruzVida
        }
    }

    void ActualizarBarraDeVida()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        
    }
}
