using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Combats;
using UnityEngine;

namespace UdemyProje1.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] GameObject attackButton;
        [SerializeField] GameObject jumpButton;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
            
        }

        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
            attackButton.SetActive(false);
            jumpButton.SetActive(false);
        }
    }
}

