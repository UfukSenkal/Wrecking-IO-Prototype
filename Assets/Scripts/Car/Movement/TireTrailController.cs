using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WreckingIO.InputSystem;

namespace WreckingIO.Car.Movement
{
    public class TireTrailController : MonoBehaviour
    {
        [SerializeField] private TrailRenderer[] _tires;
        [SerializeField] private InputData _inputData;



        private void Update()
        {
            if (_inputData.IsTouching != 0)
            {
                StartEmmit();
            }
            else
            {
                StopEmmit();

            }
        }

        private void StartEmmit()
        {
            foreach (var item in _tires)
            {
                item.emitting = true;
            }
        }
        private void StopEmmit()
        {
            foreach (var item in _tires)
            {
                item.emitting = false;
            }
        }
    }
}
