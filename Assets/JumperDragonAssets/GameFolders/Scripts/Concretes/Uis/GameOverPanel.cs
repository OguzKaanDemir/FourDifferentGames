using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProje1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButtonClicked()
        {
            GameManager.Instance.ReturnMenu();
        }
    }

}
