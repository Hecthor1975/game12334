using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaEnemiga : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float daño;

    private void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * Vector2.up);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<vida>().TomarDaño(daño);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
