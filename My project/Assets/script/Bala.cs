using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float da�o;

    public GameObject hitEffet;

    private void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * Vector2.up);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDa�o(da�o);

            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
