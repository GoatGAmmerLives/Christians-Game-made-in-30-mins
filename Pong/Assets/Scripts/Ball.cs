using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //varibles
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startpos;
    // Start is called before the first frame update
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startpos;
        Launch();
    }

    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //es factor and define
    private void Launch()
    {
        //movement
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);

    }
    
}
