using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CikisOynaYenidenBasla : MonoBehaviour
{
    
    public void Cikis()
    {
        SceneManager.LoadScene("AllGamesScene");
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("CDR-MenuScene");
    }

    public void Oyna()
    {
        SceneManager.LoadScene("CDR-OyunScene");
    }

    public void YenidenBasla()
    {
        SceneManager.LoadScene("CDR-OyunScene");
    }

}
