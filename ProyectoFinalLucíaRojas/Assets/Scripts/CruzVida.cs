using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CruzVida : MonoBehaviour
{
    public GameObject objetoPuntos;
    public float puntosQueDa;

    private void OnTriggerEnter (Collider other){

        if (other.tag == "Player"){

            objetoPuntos.GetComponent<Puntos>().puntos+=puntosQueDa;
            Destroy(gameObject);
        }
    }
}
