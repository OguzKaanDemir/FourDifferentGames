using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;


public class BasketMove : MonoBehaviour
{
    public float velocity = 3f;

    #region Basket Move

    public void LeftMove()
    {
            transform.position += new Vector3(-velocity * Time.fixedDeltaTime, 0, 0);
    }
    public void RightMove()
    {
            transform.position += new Vector3(velocity * Time.fixedDeltaTime, 0, 0);
    }
    #endregion
}
