using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCanon : MonoBehaviour
{
    public GameObject prefabBomba;
    public float fuerzaLanzamiento;
    public AudioClip sonidoDisparo;
    public float volumenSonido = 1.0f;
    public float tiempoEntreDisparos = 1.0f;
    public float velocidadRotacion = 20.0f; 

    private GameObject player;
    private AudioSource audioSource;
    private Transform canonPivot;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GetComponent<AudioSource>();
        canonPivot = transform.parent;

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            canonPivot.Rotate(Vector3.right, velocidadRotacion * Time.deltaTime); 
            canonPivot.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime); 
            yield return new WaitForSeconds(Random.Range(tiempoEntreDisparos * 0.5f, tiempoEntreDisparos * 1.5f));

            GameObject nuevaBomba = Instantiate(prefabBomba, transform.position, Quaternion.identity);
            Rigidbody rb = nuevaBomba.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 direccion = (player.transform.position - transform.position).normalized;
                transform.rotation = Quaternion.LookRotation(direccion);
                rb.AddForce(direccion * fuerzaLanzamiento, ForceMode.Impulse);

                if (audioSource != null && sonidoDisparo != null)
                {
                    audioSource.PlayOneShot(sonidoDisparo, volumenSonido);
                }
            }
            else
            {
                Debug.LogWarning("El prefabBomba no tiene un componente Rigidbody.");
            }
        }
    }
}

