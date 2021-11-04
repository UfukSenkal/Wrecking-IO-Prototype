using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WreckingIO.InputSystem
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] InputData _inputData;


        private void Update()
        {
            _inputData.ProccessInput();
        }
    }
}