using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lastscript : MonoBehaviour
{
    public void Restart()
    {
         SceneManager.LoadScene("Game");
    }
    public void quit()
    {
        Application.Quit();
    }
}
