using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initiategame : MonoBehaviour
{
    
   public void xyz()
   {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
