using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WreckingIO.Ground
{
    public class GroundTimeController : MonoBehaviour
    {
        private int _passedTime;
        private float _groundFallTime = 5f;

        private void Start()
        {
            InvokeRepeating("TimeOver", _groundFallTime, _groundFallTime);
            _passedTime = 0;
        }

        void TimeOver()
        {
            GroundManager.Instance.FallApartGround(_passedTime);
            _passedTime++;
        }
    }
}
