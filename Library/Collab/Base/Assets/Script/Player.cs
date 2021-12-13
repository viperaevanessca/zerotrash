using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float kecepatan;
    public Vector2 gerakan;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        gerakan.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate ()
    {
        rb.MovePosition(rb.position+gerakan*kecepatan*Time.fixedDeltaTime);
    }
}
