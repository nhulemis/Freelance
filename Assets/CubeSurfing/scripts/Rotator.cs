﻿using UnityEngine;

namespace CubeSurfing.scripts
{
    public class Rotator : MonoBehaviour
    {
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        public class TaoLaoTU
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaoTU()
            {
				
            }
        }
        public class TaoLaoTUxu
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaoTUxu()
            {
				
            }
        }
        public class TaoLaHUATUCSA
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHUATUCSA()
            {
				
            }
        }
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up,Time.deltaTime*speed);
        }
    }
}
