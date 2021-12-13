using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicScene1 : MonoBehaviour
{
    private static BGMusicScene1 backgroundMusic;

    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
