using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerak : MonoBehaviour
{
    public float kecepatan, scaleX;

    // Use this for initialization
    void Start () {
        scaleX = transform.localScale.x;
    }

    void jalan_kiri(){
        transform.localScale = new Vector3 (-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.left*kecepatan*Time.fixedDeltaTime, Space.Self);
    }

    void jalan_kanan(){
        transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right*kecepatan*Time.fixedDeltaTime, Space.Self);
    }

    // Update is called once per frame
    void Update (){
        if (Input.GetKey (KeyCode.LeftArrow)) {
            jalan_kiri();
        } else if (Input.GetKey (KeyCode.RightArrow)) {
            jalan_kanan();
        }
    }
}
