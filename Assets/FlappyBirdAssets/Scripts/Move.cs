using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        Destroy(this.gameObject, 10);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}
