using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployikan : MonoBehaviour
{
    public GameObject ikankuningPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;


    // Use this for intialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ikankuningWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(ikankuningPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator ikankuningWave(){
        while(true) {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
