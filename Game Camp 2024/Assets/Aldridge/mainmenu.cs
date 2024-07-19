using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
  public void Play()
  {
    SceneManager.LoadScene("WhiteBox");
  }
  public void Quit()
  {
    Application.Quit();
  }
  public void Credits()
  {
    SceneManager.LoadScene("Credits");
  }  
}
