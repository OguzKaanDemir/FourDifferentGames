using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonLongPresser : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum Direction{
        left,right
    };
    public bool buttonPressed;
    [SerializeField] private BasketMove basketMove;
    [SerializeField] private Direction direction;

    private void Start()
    {
        basketMove = FindObjectOfType<BasketMove>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
    private void Update()
    {
        if (buttonPressed)
        {
            if (direction == Direction.left)
            {
                basketMove.LeftMove();
            }
            else
            {
                basketMove.RightMove();
            }
        }
    }
}
