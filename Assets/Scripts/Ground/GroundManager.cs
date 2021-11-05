using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WreckingIO.Ground
{
    public class GroundManager : MonoBehaviour
    {
        public static GroundManager Instance;

        [SerializeField] List<Rigidbody> _groundPartList;


        private void Awake()
        {
            Instance = this;


        }
        public void FallApartGround(int i)
        {
            if (_groundPartList.Count > i)
            {
                for (int j = 0; j < _groundPartList[i].transform.childCount; j++)
                {
                    _groundPartList[i].transform.GetChild(j).GetComponent<MeshCollider>().isTrigger = true;
                }
                _groundPartList[i].isKinematic = false;
                _groundPartList[i].AddRelativeForce(Vector3.down * 50f);
                
            }
            
        }


    }
}
