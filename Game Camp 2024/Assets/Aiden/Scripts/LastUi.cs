using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastUi : MonoBehaviour
{   
    public void Retry()
    {
      Scene currentScene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(currentScene.buildIndex);
    }
    public void GiveUp()
    {
      SceneManager.LoadScene("MainMenu");
    }
}
