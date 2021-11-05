using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WreckingIO.Ball
{
    public class BallLineController : MonoBehaviour
    {

        [SerializeField] LineRenderer _lineRenderer;
        [SerializeField] Transform _carTransform;

        private void Update()
        {
            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1, _carTransform.position);
        }
    }
}
