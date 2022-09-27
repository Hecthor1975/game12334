using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamaraHorizontal : MonoBehaviour
{
    public float speed;
    public float limiteIzquierda, limiteDerecha;
 
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * x * Time.deltaTime * speed);
        Vector3 pos = transform.position;
        pos.x = pos.x = Mathf.Clamp(pos.x, limiteIzquierda, limiteDerecha);
        transform.position = pos;
    }
}
