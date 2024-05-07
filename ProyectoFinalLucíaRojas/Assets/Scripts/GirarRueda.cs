using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



public class GirarRueda : MonoBehaviour
{
 public Animator PuertaAnimator;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
           
            GameObject rueda = GameObject.FindGameObjectWithTag("Rueda");
            
            
            rueda.transform.Rotate(Vector3.forward, 180f);
             
            
            
            PuertaAnimator.SetTrigger("AbrirPuerta");
        }
    }
}