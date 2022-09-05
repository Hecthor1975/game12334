using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCargado : MonoBehaviour
{
    [SerializeReference] private Transform controladorDisparo;
    [SerializeReference] private GameObject[] balas;
    [SerializeReference] private float maximoCarga;
    [SerializeReference] private float tiempoCarga;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (tiempoCarga <= maximoCarga)
            {
                tiempoCarga += Time.deltaTime;
            }
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Disparar((int)tiempoCarga);
            tiempoCarga = 0;
        }

    }

    private void Disparar(int tiempoDeCarga)
    {
        Instantiate(balas[tiempoDeCarga], controladorDisparo.position, controladorDisparo.rotation);
    }
}
