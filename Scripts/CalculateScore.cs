using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class CalculateScore : MonoBehaviour
{
   private float t;
   private int x;
   public Text Score;
    // Update is called once per frame
  
     void start()
     {
         
     }
    
    void Update()
    {
       // t=Time.time;
        //Score.text=t.ToString("0");
        x=GameObject.Find("BlockSpawner").GetComponent<CallBlocks>().scr();
        Score.text=GameObject.Find("BlockSpawner").GetComponent<CallBlocks>().scr().ToString();
        if(x>PlayerPrefs.GetInt("HighScore",0))
        {
            //PlayerPrefs.SetInt("HighScore",Convert.ToInt32(t));
            PlayerPrefs.SetInt("HighScore",x);
        }
    }
}
