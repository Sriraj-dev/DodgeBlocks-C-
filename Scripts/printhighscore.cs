using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class printhighscore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highscore;
    void Update()
    {
        highscore.text=PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    
}
