using TMPro;
using UnityEngine;

namespace Arrow.Script
{
    public class MultiTextController : MonoBehaviour
    {
        public Color32 subsData;
        public TextMeshProUGUI text;
        public Color32 positData;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(this.gameObject,1f);
        }

        class HSUQOXkkoaw1
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUQOXkzkockosa2
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUcjiaojxjsi3
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(Vector3.up * 3+Vector3.right*3f);
        }
        public void setData(float value)
        
        
        
        {
            if (value > 0)
            {
                
                
                
                
                
                
                int collectedVal = Random.Range(20, 50);
                text.text = "+" + collectedVal + "$";
                //  text.color = positData;
            }
            else
            {
                int collectedVal = Random.Range(-50, -20);
                text.text =  collectedVal + "$";
                text.faceColor = subsData;

            }

        }
    }
}
