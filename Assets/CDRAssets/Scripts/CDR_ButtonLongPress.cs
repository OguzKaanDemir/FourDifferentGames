using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class CDR_ButtonLongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum Direction
    {
        left, right
    };
    public bool buttonPressed;
    [SerializeField] private ArabaController arabaMove;
    [SerializeField] private Direction direction;
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void Start()
    {
        arabaMove = FindObjectOfType<ArabaController>();
    }
    private void Update()
    {
        arabaMove.movement = Input.GetAxis("Horizontal");
        arabaMove.image.fillAmount = arabaMove.fuel;
    }

    void FixedUpdate()
    {
        if (buttonPressed)
        {
            if (direction == Direction.left && arabaMove.fuel > 0)
            {
                arabaMove.movement = -1;
                arabaMove.ArabaHareket();
                arabaMove.fuel -= arabaMove.fuelCosumption * Mathf.Abs(arabaMove.movement) * Time.fixedDeltaTime;
            }
            else
            {
                if (arabaMove.fuel > 0)
                {                    
                    arabaMove.movement = 1;
                    arabaMove.ArabaHareket();
                    arabaMove.fuel -= arabaMove.fuelCosumption * Mathf.Abs(arabaMove.movement) * Time.fixedDeltaTime;
                }
                
            }
            
        }
    }
    
}
