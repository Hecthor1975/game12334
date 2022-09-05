using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    [SerializeField] private float Vida;

    public void TomarDa�o (float da�o)
    {
        Vida -= da�o;

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
