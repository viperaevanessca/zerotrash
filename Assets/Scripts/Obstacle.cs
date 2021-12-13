using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime );
    }
}
