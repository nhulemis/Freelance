﻿using UnityEngine;

namespace PetsIO._Scripts
{
    public class Rotate : MonoBehaviour
    {
        public Vector3 RotVector3;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(RotVector3*Time.deltaTime);
        }
    }
}
