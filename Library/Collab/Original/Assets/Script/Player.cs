using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ground, parent_obstacle, gameover, reset_button;
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

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "obstacle") {
            GetComponent<Animator>().enabled = false;
            ground.GetComponent<Animator>().enabled = false;
            parent_obstacle.GetComponent<duplicate_obstacle>().gameover = true;
            for (int i=0; i<parent_obstacle.transform.childCount; i++){
                parent_obstacle.transform.GetChild(i).GetComponent<obstacle>().speed = 0;
            }
        }
    }
}
