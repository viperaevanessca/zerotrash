using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_sampah : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed,0,0);
        if(transform.position.x<-15) {
            Destroy(gameObject);
        }

    }
}
