using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafGravity : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        move = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
}
