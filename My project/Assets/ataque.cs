using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    [SerializeField] private int daño;



    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<vida>().TomarDaño(daño);
            Destroy(gameObject);
        }
          
    }
}