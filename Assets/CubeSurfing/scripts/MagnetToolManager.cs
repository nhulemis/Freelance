using UnityEngine;

namespace CubeSurfing.scripts
{
    public class MagnetToolManager : MonoBehaviour
    {
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
        public class TaoLaHUATUC
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHUATUC()
            {
				
            }
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "towerbuild")
            {
                TowerBuilder.instance.addToBuilding(other.gameObject);
            }
        }
    }
}
