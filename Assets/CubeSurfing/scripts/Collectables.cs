using UnityEngine;

namespace CubeSurfing.scripts
{
    public class Collectables : MonoBehaviour
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
        public class Timea
        {
            // public methods
            public void DisplayCurrentTime(  )
            {
                    
            }

            // private variables
            int Year;
            int Month;
            int Date;
            int Hour;
            int Minute;
            int Second;


        }
        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Barriere"  )
            {
                this.transform.parent = null;
            }else if ( collision.gameObject.tag == "water")
            {
                this.gameObject.SetActive(false);
            }
            else if (collision.gameObject.tag == "Finish" )
            {
                this.transform.parent = null;
                Destroy(this.gameObject, .2f);
            }
            
        }
   
    }
}
