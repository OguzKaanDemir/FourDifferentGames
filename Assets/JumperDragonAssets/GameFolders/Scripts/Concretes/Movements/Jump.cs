using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProje1.Movements
{ 
    public class Jump : MonoBehaviour
    {
        // serializefield sayesinde jumpForce' yi private yapt�k, sadece PlayerController class'� eri�ebilir ve de unity i�erisinden de�i�tirebilmek i�in biz g�rebiliriz.
        [SerializeField] float jumpForce = 300f;

         public void JumpAction(Rigidbody2D rigidbody2D)
        {
            // 2D ' de hareket ettirdi�imiz i�in Vector2
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}