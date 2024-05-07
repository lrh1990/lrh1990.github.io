using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class Bomba : MonoBehaviour
{
    public UnityEvent OnPlayerHit; // Evento que se activar cuando la bomba colisione con el jugador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerHit.Invoke(); // Activa el evento de colisin con el jugador
            Destroy(gameObject); // Destruye la bomba
        }
    }
}