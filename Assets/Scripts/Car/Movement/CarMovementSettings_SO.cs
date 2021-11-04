using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WreckingIO.Car.Movement
{
    [CreateAssetMenu(menuName = "WreckingIO/Car/Car Settings")]
    public class CarMovementSettings_SO : ScriptableObject
    {
        [SerializeField] private float _carSpeed = 1f;
        [SerializeField] private float _carRotationSpeed = 1f;

        public float CarSpeed { get { return _carSpeed; } }
        public float CarRotationSpeed { get { return _carRotationSpeed; } }
    }
}
