using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;


    private void Update()
    {
        if (puntos < 0)
        {
            RestarPuntos(-puntos);
        }
        else
        {
            textoPuntos.text = "Puntos: " + puntos.ToString();
        }
    }

    public void RestarPuntos(float puntosARestar)
    {
        puntos -= puntosARestar;
        textoPuntos.text = "Puntos: " + puntos.ToString();
    }
}