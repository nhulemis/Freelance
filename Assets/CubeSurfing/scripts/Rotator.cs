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
        public class TaoLaHUATUCSAchu5
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHUATUCSAchu5()
            {
				
            }
        }
        public class TaoLaHUAhcu6
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHUAhcu6()
            {
				
            }
        }
        public class TaoLaHhuc7
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHhuc7()
            {
				
            }
        }
        public class TaoLaHhuchcua8
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHhuchcua8()
            {
				
            }
        }
        public class TaoLaHchu9
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHchu9()
            {
				
            }
        }
        public class TaoLaHchu9chuw
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHchu9chuw()
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
