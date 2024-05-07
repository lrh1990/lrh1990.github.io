using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlInicioJuego : MonoBehaviour

{
    public GameObject panelInicio; 
    public Text textoInicio; 
    public string textoCompleto = "Comienza el juego"; 
    public float velocidadEscritura = 0.1f; 

    private void Start()
    {
       
        StartCoroutine(EscribirTexto());
    }

    private IEnumerator EscribirTexto()
    {
        textoInicio.text = "";

    
        foreach (char letra in textoCompleto)
        {
            
            textoInicio.text += letra;

            
            yield return new WaitForSeconds(velocidadEscritura);
        }

        
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
               
                panelInicio.SetActive(false);
                break;
            }
            yield return null;
        }
    }
}
