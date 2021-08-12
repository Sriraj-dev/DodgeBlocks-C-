using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
   

   public Rigidbody2D rb;
   public float speed=15f;
   

    // Update is called once per frame
    void Update()
    {
       if(Input.touchCount >0)
        {
           Debug.Log("Touch inititated");

              Vector2 touch =Input.GetTouch(0).position;
              if(touch.x>Screen.width * 0.5f )
              { 
               
                // rb.AddForce(new Vector2( speed * Time.deltaTime, 0));
                Vector2 vr=rb.velocity;
                  Debug.Log("Right");
                vr.x=speed;
                vr.y=0;
                rb.velocity=vr;
                
              }
              else if(touch.x<Screen.width * 0.5f)
              {
                 Debug.Log("Left");
                //rb.AddForce(new Vector2( -1*speed * Time.deltaTime, 0));
                Vector2 vl=rb.velocity;
                vl.x=-speed;
                vl.y=0;
                rb.velocity=vl;

              }
              
        }


    }
}
