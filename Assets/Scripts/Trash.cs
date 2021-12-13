using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           Destroy(gameObject);
        }
       
    }
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime );
    }
}
