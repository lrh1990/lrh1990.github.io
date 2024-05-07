using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Text textoPuntos;
    private int puntos = 100;

    void Start()
    {
        ActualizarPuntos();
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemigo"))
        {
            Debug.Log("Colisión con enemigo");
            puntos -= 10;
            ActualizarPuntos();
            Destroy(collision.gameObject); // Destruir el objeto enemigo
        }
    }


    void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("CruzVida"))
        {
            puntos += 100;
           Destroy(other.gameObject);
        }
        
        ActualizarPuntos();
    }

    void ActualizarPuntos()
    {
        textoPuntos.text = "Puntos: " + puntos.ToString();
    }
}
