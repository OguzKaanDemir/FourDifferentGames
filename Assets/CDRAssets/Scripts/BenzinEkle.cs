using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenzinEkle : MonoBehaviour
{
    public ArabaController arabaController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        arabaController.fuel = 1f;
        Destroy(gameObject);
    }
}
