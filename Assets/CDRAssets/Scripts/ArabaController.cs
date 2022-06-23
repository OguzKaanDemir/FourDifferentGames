using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaController : MonoBehaviour
{
    public float fuel = 1f;
    public float fuelCosumption = 0.08f;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 93.5f;
    public float carTorque = 350f;
    public UnityEngine.UI.Image image;
    public float movement;
    void Update()
    {
        image.fillAmount = fuel;
    }
    private void FixedUpdate()
    {
        fuel -= fuelCosumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }

    public void ArabaHareket()
    {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
    }
}
