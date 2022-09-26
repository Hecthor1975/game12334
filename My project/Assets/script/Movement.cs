using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public int score;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }
   
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x*speed,y*speed);
    }
}
