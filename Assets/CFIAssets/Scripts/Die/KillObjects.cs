using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillObjects : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision1)
    {
        Destroy(collision1.gameObject);
    }
}
