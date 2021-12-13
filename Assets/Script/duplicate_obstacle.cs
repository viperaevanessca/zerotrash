using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicate_obstacle : MonoBehaviour
{
    public bool gameover = false;
    public GameObject obstacle_prefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(duplicate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator duplicate () {
        while(!gameover){
        float distance_obs = Random.Range(1,4);
        yield return new WaitForSeconds(distance_obs);
        GameObject obstacle = Instantiate(obstacle_prefab, transform.position, transform.rotation, transform);
        obstacle.name = "obstacle";
        }
    }
}
