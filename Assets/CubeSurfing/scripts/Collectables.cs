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
