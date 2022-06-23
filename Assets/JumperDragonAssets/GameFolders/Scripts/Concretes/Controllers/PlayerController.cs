using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Combats;
using UdemyProje1.Movements;
using UnityEngine;


namespace UdemyProje1.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        // private field
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        Dead _dead;


        private void Awake()
        {
            // PlayerController.cs ile RigidBody2D ayný dizinde oluðu için (ayný elemanda) ona ulaþabiliyoruz.
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
            _dead = GetComponent<Dead>();
            // kullanabilmemiz için newlememiz gerekiyor Instance alýyoruz...
            _input = new PcInputController();
        }

        private void Update() // her 1 frame'de çalýþýr. ve olabildiðince az komut yazýlmalýdýr. her yazýlan kodda fps düþer.
        {
            if (_dead.IsDead)
            {
                return;
            }

            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
            }
            
        }

        

        public void JumpButton()
        {
            _jump.JumpAction(_rigidbody2D);
            _audioSource.Play();
        }

        
    }
}