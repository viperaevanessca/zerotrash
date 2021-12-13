using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Trash)
    {
        if(Trash.tag=="trash")
        {
            ScoreNum++;
            Destroy(Trash.gameObject);
            MyScoreText.text = "Score : " + ScoreNum;
        }
    }
}
