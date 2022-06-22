using UnityEngine;

namespace CubeSurfing.scripts
{
    public class CharactereController : MonoBehaviour
    {
        public  enum  gameState { playing, stop };
        public static gameState state;
        public float speed=1;
        public Transform target;
        public Transform lefttarget;
        public bool rotate;
        private Vector3 direction;
        private float t = 1;  
        private float minx, maxx;
        private bool forward;
        private bool left;
        private Vector3 offset;
        private Vector3 curentpos;
        public static CharactereController instance;
    
        public class TaoLaHUATUC
        {
            public float shakeSpeed;
            public MeshFilter meshF;
            private Mesh mesh;
            private int length;

            public TaoLaHUATUC()
            {
				
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
        void Awake(){
            if(instance==null)instance=this;
            else if(instance!=this)Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            left = false;
            minx = -1.95f;
            maxx = 1.95f;
            forward = true;
            direction = transform.forward;
            state = gameState.stop;
        }

        // Update is called once per frame
        void Update()
        {
            if (rotate)
            {
                Vector3 targetpos = target.position;
                targetpos.y = 0;
           
                Quaternion newrotation = Quaternion.LookRotation(targetpos);
                transform.rotation = Quaternion.Lerp(this.transform.rotation, newrotation, Time.deltaTime * 10);
            }
            if (left)
            {
                Vector3 targetpos = lefttarget.position;
                targetpos.y = 0;

                Quaternion newrotation = Quaternion.LookRotation(targetpos);
                transform.rotation = Quaternion.Lerp(this.transform.rotation, newrotation, Time.deltaTime * 10);
            }
            if (Input.GetMouseButtonDown(0))
            {
                offset = Input.mousePosition;
                offset.z = 10;
                offset = Camera.main.ScreenToWorldPoint(offset);
            }
            if (Input.GetMouseButton(0))
            {
                curentpos = Input.mousePosition;
                curentpos.z = 10;
                curentpos = Camera.main.ScreenToWorldPoint(curentpos);



            }
            if ((curentpos - offset).magnitude > .5f && state==gameState.playing)
            {
                if (forward)
                {
                    // transform.Translate(new Vector3(((curentpos - offset) - transform.forward).x, 0, 0) * Time.deltaTime);
                    float rotx = Input.GetAxis("Mouse X") * 2.5f * Mathf.Deg2Rad;
                    transform.position += new Vector3(rotx, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), 0, transform.position.z);
                }

                else 
                {
                    print(curentpos);
                    Vector3 newpos = (curentpos  - transform.position);
                    float rotx = Input.GetAxis("Mouse X") * 2.5f * Mathf.Deg2Rad;
                    transform.position += new Vector3(0, 0,rotx*t);
                    // transform.position += new Vector3(0, 0, newpos.z*Time.deltaTime) ;
                    transform.position = new Vector3(transform.position.x, 0, Mathf.Clamp(transform.position.z, minx, maxx));
                }
                
                // transform.position += new Vector3(Mathf.Clamp((curentpos - offset).x+transform.position.x,-1.5f,1.5f), 0, 0) * Time.deltaTime;
            }
            switch (state)
            {
                case gameState.playing:
                    // transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
                    transform.position+=direction * Time.deltaTime * speed;
                    break;
                case gameState.stop:
               
                    break;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "right")
            {
                minx =111f;
                maxx =114f;
        
                curentpos = Vector3.zero;
                offset = Vector3.zero;
                t = -1;
                direction = transform.right;
                rotate = true;
                forward = false;
            }
            if (other.gameObject.tag == "left")
            {
                minx = 111f;
                maxx = 114.5f;
                curentpos = Vector3.zero;
                offset = Vector3.zero;
                t = 1;
                direction =- transform.right;
                left = true;
                rotate = false;
                forward = false;
            }
            if (other.gameObject.tag == "SpeedUp")
            {
                print("Yeaaaaah Speeeed");
            }


        }
        public void changeSpped(int value){
            speed+=value;
            Invoke("resetSpeed",2f);
        }
        private void resetSpeed(){
            speed=12;
        }

    }
}
