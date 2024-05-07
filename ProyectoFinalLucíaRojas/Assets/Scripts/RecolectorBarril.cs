using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class RecolectorBarril : MonoBehaviour
{
    public Text barrilesText; 
    private int barrilesRecogidos = 0; // Contador de barriles recogidos


    // Metodo que se llama cuando el jugador colisiona con el barril
    private void OnCollisionEnter(Collision collision)
    {
        // Verificamos si el objeto con el que colision el jugador es un barril
        if (collision.gameObject.CompareTag("Barril"))
        {
            // Destruimos el barril
            Destroy(collision.gameObject);
           barrilesRecogidos++;

            // Actualizar el texto en el panel
             barrilesText.text = barrilesRecogidos.ToString();

            
        }
    }
    }


