using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastUi : MonoBehaviour
{
    public Sprite[] Sprites;
    public NPCCounter np;
    
    public void SpriteResult()
    {
        if(np.currentScore >= 8000)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[0];
        }
        if(np.currentScore < 8000 && np.currentScore > 6000)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[1];
        }
        if(np.currentScore < 6000 && np.currentScore > 4000)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[3];
        }
        if(np.currentScore < 4000 && np.currentScore > 2000)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[4];
        }
        if(np.currentScore < 2000 && np.currentScore > 0)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites[5];
        }
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
