using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tesgerak : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    
    // Use this for intialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
