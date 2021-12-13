using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batas : MonoBehaviour
{
    void start()
    {
        transform.position = new Vector3(-5,0,0);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >=4.7f){
            transform.position = new Vector3(transform.position.x, 4.7f, 0);
        }
        else if(transform.position.y <= -4.3f){
            transform.position = new Vector3(transform.position.x, -4.3f, 0);
        }
    }
}
