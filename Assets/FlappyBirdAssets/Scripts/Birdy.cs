using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool _isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager1 managerGame;
    public GameObject DeathScene;

    void Update()
    {
        // sol click al
        if (Input.GetMouseButtonDown(0))
        {
            // ku�u z�plat�r
            rb2D.velocity = Vector2.up * velocity; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            _isDead = true;
            Time.timeScale = 0;
            DeathScene.SetActive(true);
        }
    }

}
