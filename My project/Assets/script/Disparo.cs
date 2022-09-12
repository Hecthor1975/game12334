using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private List<Transform> controladorDisparo;
    [SerializeField] private GameObject bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            //Disparar
            Disparar();
        }
    }
    private void Disparar()
    {
        for (int i = 0; i < controladorDisparo.Count; i++) { 
           Instantiate(bala, controladorDisparo[i].position, controladorDisparo[i].rotation);
        }
    }
}

