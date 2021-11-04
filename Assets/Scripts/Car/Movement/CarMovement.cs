using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WreckingIO.Car.Movement {
    public class CarMovement : AbstractCarBase
    {
        [SerializeField] private CarMovementSettings_SO _carSettings;


        private void Update()
        {
            Move();
        }

        public override void Move()
        {
            transform.Translate(transform.forward * _carSettings.CarSpeed, Space.World);
        }
    }
}
