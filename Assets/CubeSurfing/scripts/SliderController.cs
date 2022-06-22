using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubeSurfing.scripts
{
    public class SliderController : MonoBehaviour
    {
        float distance;
        Vector3 startPos;
        Vector3 endpos;
        Transform playerTrans;
        [SerializeField]Image imgSlider;
        public class TaoLaoTU
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private List<int> trianglesIndices;
            private List<Vector3> vertices;
            private int length;

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
            public TaoLaoTU()
            {
				
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            playerTrans=GameObject.FindGameObjectWithTag("Player").transform;
            startPos=playerTrans.position;
            endpos=GameObject.FindGameObjectWithTag("Ending").transform.position;
            distance=(endpos-startPos).magnitude;
        
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
        void LateUpdate()
        {
            imgSlider.fillAmount=((playerTrans.position).magnitude/distance);
        }
    }
}
