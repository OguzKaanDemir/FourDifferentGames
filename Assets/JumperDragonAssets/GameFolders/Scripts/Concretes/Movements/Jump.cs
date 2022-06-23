using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProje1.Movements
{ 
    public class Jump : MonoBehaviour
    {
        // serializefield sayesinde jumpForce' yi private yaptýk, sadece PlayerController class'ý eriþebilir ve de unity içerisinden deðiþtirebilmek için biz görebiliriz.
        [SerializeField] float jumpForce = 300f;

         public void JumpAction(Rigidbody2D rigidbody2D)
        {
            // 2D ' de hareket ettirdiðimiz için Vector2
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}