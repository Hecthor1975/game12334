using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float daño;

    public GameObject hitEffect;

    private void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * Vector2.up);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            collision.GetComponent<Enemigo>().TomarDaño(daño);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.8f);
            Destroy(gameObject);
        }
        else
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.8f);
            Destroy(gameObject);
        }
    }

}
