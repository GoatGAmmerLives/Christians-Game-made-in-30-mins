using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //varibles
    public bool isplayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startpos;

    private float Movement;

    public void Start()
    {
        startpos = transform.position;
    }
    public void Update()
    {
        if (isplayer1)
        {
            Movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            Movement = Input.GetAxisRaw("Vertical2");
        }
        
        //rb
        rb.velocity = new Vector2(rb.velocity.x, Movement * speed);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startpos;
    }
}
