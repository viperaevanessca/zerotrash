using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=new Vector3(-2*Time.deltaTime,0);

        if(transform.position.x < -17.77)
        {
            transform.position=new Vector3(17.77f,transform.position.y);
        }
    }
    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(0,2.5f),0);
    }
}
