using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fijar : MonoBehaviour
{
    [SerializeField] private Transform objetivo;

    private void Update()
    {
        float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, -transform.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
