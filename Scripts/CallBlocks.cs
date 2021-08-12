using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBlocks : MonoBehaviour
{
    public Transform[] SpawnLocation;

    public GameObject Block;
    // Start is called before the first frame update
    public float timegap=5f;
    public float timediff=1f;
    
     public int Score=1;
     
     void Start()
     {
         Score=-1;
     }
    void SpawnBlocks()
    {
        int r=Random.Range(0,5);

        for(int i=0;i<5;i++)
        {
            if(i!=r)
            {
                Instantiate(Block, SpawnLocation[i].position, Quaternion.identity);
 
            }
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Time.time>=timegap)
        {
            SpawnBlocks();
            timegap=Time.time +timediff; 
            Score+=1;
        }
        
    }
    public int scr()
    {
         return Score;
    }
}
