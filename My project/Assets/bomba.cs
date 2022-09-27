using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    [SerializeField] private float radio;
    [SerializeField] private float fuerzadeexplocion;
    private IEnumerable<Collider2D> Enemigo;

    public void Explosion()
    {
        Collider2D[] Enemigo = Physics2D.OverlapCircleAll(transform.position,radio);

        foreach (Collider2D colisionador in Enemigo)
        {
            Rigidbody2D rb2D = colisionador.GetComponent<Rigidbody2D>();
            if (rb2D != null)
            {
                Vector3 direccion = colisionador.transform.position - transform.position;
                float distancia = 1 + direccion.magnitude;
                float fuerzaFinal = fuerzadeexplocion / distancia;
                rb2D.AddForce(direccion * fuerzaFinal);
            }
        }
        Destroy(gameObject);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
