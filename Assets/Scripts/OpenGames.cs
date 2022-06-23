using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGames : MonoBehaviour
{
    void Start()
    {
        
        Destroy(GameObject.Find("[GameManager]"));
        Destroy(GameObject.Find("RedDragonPool"));
        Destroy(GameObject.Find("ObsticlePool"));
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void OpenFlappyBird()
    {
        SceneManager.LoadScene("FBMenuScene");
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void OpenJumperDragon()
    {
        SceneManager.LoadScene("JD-Menu");
    }

    public void OpenCFI()
    {
        SceneManager.LoadScene("CFI-MenuScene");
    }

    public void OpenCDR() 
    {
        SceneManager.LoadScene("CDR-MenuScene");
    }
}
