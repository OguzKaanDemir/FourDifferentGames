using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje1.Controllers
{
    public class PcInputController
    {
        // Input.GetMouseButtonDown(0) = Mouse Sol butona t�kland�ysa; (0 sol click, 1 sa� click, 2 orta tu�)
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}
