using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    [SerializeField] private int da�o;



    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<vida>().TomarDa�o(da�o);
            Destroy(gameObject);
        }
          
    }
}