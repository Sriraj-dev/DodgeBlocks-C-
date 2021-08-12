using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  

    // Update is called once per frame
    public void EndGame()
    {

        Debug.Log("Goodbye");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}
