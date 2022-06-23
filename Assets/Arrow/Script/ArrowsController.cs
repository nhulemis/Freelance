using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arrow.Script
{
    public class ArrowsController : MonoBehaviour
    {
        private ArrowPlacementManager arrowPlacement;
        private bool moveForward;
        private bool camCanFollow;
        //Serialized Data
        [SerializeField]
        private Transform childHolder;
        private int currentCollectedCoinTemp;

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

        class HSUckvoawopvp4
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class CHusjxoacm6x
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        //References
        public static ArrowsController instance;
        private void Awake()
        {
            if (!instance) instance = this;

            arrowPlacement = this.GetComponent<ArrowPlacementManager>();
        }
        // Start is called before the first frame update
        void Start()
        {
            camCanFollow = true;
        }

        // Update is called once per frame
        Transform levelDoneObj;
        void Update()
        {
            if (moveForward)
            {
                if (camCanFollow)
                {
                    CameraController.instance.finalChase(this.transform);
                    Vector3 direction = levelDoneObj.position - this.transform.position;

                    this.transform.position += direction.normalized * Time.deltaTime * 12;
                }
                else
                {
                    this.transform.position += Vector3.forward * Time.deltaTime * 12;

                }

            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Multiplier"))
            {
                other.gameObject.GetComponent<Collider>().enabled=false;
                currentCollectedCoinTemp+=2;
                DoorController dController = other.gameObject.GetComponent<DoorController>();
                int value = dController.getValue();
                switch (dController.operatoor)
                {
                    case operatoors.Devide:
                        arrowPlacement.devide(value);
                        break;
                    case operatoors.Minus:
                        arrowPlacement.subs(value);
                        break;
                    case operatoors.Multiply:
                        arrowPlacement.multiply(value);
                        break;
                    case operatoors.Plus:
                        arrowPlacement.AddRunners2(value);
                        break;

                }
            
            
                //  arrowPlacement.AddRunners(5);
                
            }
            if (other.gameObject.CompareTag("LevelDone"))
            {
                SceneManager.LoadScene("1");
                // moveForward = false;
            }
            if (other.gameObject.CompareTag("Helper"))
            {
                shoot(other.gameObject.GetComponentInParent<StageController>());
            }
            if (other.gameObject.CompareTag("Enemy"))
            {
                other.gameObject.GetComponent<Collider>().enabled = false;
                shootEnemy(other.gameObject.GetComponentInParent<BossController>().getTarget());
                //Destroy(other.gameObject);
            }

        }
        public void freeArrows1()
        {
            levelDoneObj = GameObject.FindGameObjectWithTag("LevelDone").transform;
            moveForward = true;
            arrowPlacement.attackSpecialPlacement = true;
            CameraController.instance.ChaseEnable = false;

        }
        private void shoot(StageController stageController)
        {
            BossController[] targets = stageController.getBosses();
            Transform myTrans=this.transform;
            int length = 0;
            length = targets.Length;
     
            for (int i = 0; i < length; i++)
            {
                int j = 8;
                if (!moveForward)
                {
                    if (childHolder.childCount > i)
                        childHolder.GetChild(i).GetComponent<ArrowChildManager>().shoot(targets[i].getTarget());
                    else
                    {
                        levelDone();
                        return;
                    }
                }
                else
                {
                    while(j>0)
                    {
                        if (childHolder.childCount > j)
                            childHolder.GetChild(j).GetComponent<ArrowChildManager>().shoot(targets[i].getTarget());
                        else
                        {
                            levelDone();
                            return;
                        }
                        j--;
                    }
                
                }

                



            }
        
        }
        private void shootEnemy(Transform enemyTrans)
        {
            childHolder.GetChild(0).GetComponent<ArrowChildManager>().shoot(enemyTrans);
        }
        private void levelDone()
        {

            UiManager.instance.assignCurrentCollectedCoin(currentCollectedCoinTemp);
            GameManager.instance.winGame();
            camCanFollow = false;
        }
        public void addByCommand(int amount)
        {
            arrowPlacement.AddRunners2(amount);
        }
    }
}
