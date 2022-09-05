using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    [SerializeField] private float Vida;

    public void TomarDaño (float daño)
    {
        Vida -= daño;

        if (Vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public float GetVida()
    {
        return Vida;
    }
}
