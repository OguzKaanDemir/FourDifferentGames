using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public float _scaleX = 0f;
    public float _scaleY = 0f;
    public int _canAzalt = 0;
    public Text _pointText;
    public int point = 0;

    void Update()
    {
        BoyutArttir();
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hamburger")
        {
            Destroy(collision.gameObject);
            point += 10;
            PointTextUpdate(point);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hotdog")
        {
            Destroy(collision.gameObject);
            point += 10;
            PointTextUpdate(point);
        }

        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            _canAzalt++;
        }
    }

    public void BoyutArttir()
    {
        transform.localScale = new Vector3(_scaleX, _scaleY, 0f);
    }
    public void PointTextUpdate(int point)
    {
        _pointText.text = point.ToString();
    }
}
