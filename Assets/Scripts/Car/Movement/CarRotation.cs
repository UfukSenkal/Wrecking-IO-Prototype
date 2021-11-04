using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WreckingIO.InputSystem;

namespace WreckingIO.Car.Movement
{
    public class CarRotation : MonoBehaviour
    {
        [SerializeField] CarMovementSettings_SO _carSettings;
        [SerializeField] InputData _inputData;
        private void Update()
        {
           
                transform.Rotate(0, _inputData.IsTouching * (_inputData.IsLeft ? _carSettings.CarRotationSpeed : -_carSettings.CarRotationSpeed), 0, Space.Self);
            
        }
    }
}
