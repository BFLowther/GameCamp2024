using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausegame : MonoBehaviour
{
    bool isPaused = false;
    public GameObject pausePanel;
    
    void Start()
    {
        pausePanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown("Cancel") && isPaused == false )
      {
        Time.timeScale = 0.0f;
        pausePanel.SetActive(true);
        isPaused = true;
        Debug.Log("Game Paused");
      }
      else if (Input.GetButtonDown("Cancel") && isPaused == true)
      {
        Resume();
      }
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        Debug.Log("Game Paused");
        pausePanel.SetActive(false);
    }
    
    public void Quit()
    {
       Application.Quit();
       Debug.Log("Quit Game"); 
    }


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
