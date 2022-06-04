using UnityEngine;

namespace Samurai.Scripts
{
    public class EnemyShooterController : MonoBehaviour
    {
        [SerializeField]
        private GameObject bullet;
        [SerializeField]
        private Transform target;
        [SerializeField]
        
        
        
        
        
        
        
        
        
        private Transform shootPos;
        [SerializeField]
        private Animator anim;
        [SerializeField]
        private Material cutMaterial;
    

        private float lastTimeShoot=1;
        public float bulletSpeed=1;
        private Rigidbody rb;
        private Rigidbody[] childrb;
        private bool isAlive;
        public  SkinnedMeshRenderer skinMesh;
        private float distanceToShoot=30f;

    
        // Start is called before the first frame update
        void Start()
        {
            target=GameObject.FindWithTag("AttackSlicer").transform;
            isAlive=true;
            childrb=this.GetComponentsInChildren<Rigidbody>();
            skinMesh=this.GetComponentInChildren<SkinnedMeshRenderer>();
            rb=this.GetComponent<Rigidbody>();
            print("Child Count"+this.transform.childCount);
        }

        // Update is called once per frame
        void Update()
        {
            switch(GameManager.instance.currentState){
                case GameManager.GameState.play :
                    if(isAlive){
                        this.transform.LookAt(target.position);
                        transform.eulerAngles=new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
                        float distanceToTarget=Vector3.Distance(target.position,this.transform.position);
                        //print("DISTANCE tO target IS : "+distanceToTarget);
                        if(Time.time>lastTimeShoot+3f && distanceToTarget<distanceToShoot){
                            shoot();
                            lastTimeShoot=Time.time;

                        }

                    }
        
                    break;
            }
        }
        private void shoot(){
            print("Shoot");
            Vector3 direction=target.position-shootPos.position;
            print("Target y position is : "+target.position.y);
            GameObject bulletObj=Instantiate(bullet,new Vector3(shootPos.position.x,target.position.y,shootPos.position.z),Quaternion.identity);
            Rigidbody bulletRb=bulletObj.GetComponent<Rigidbody>();
    	
        
            bulletRb.velocity=direction.normalized*bulletSpeed;

        }
        private void kill(){
            //kick();
            enableRagdoll();
        }
        private void kick(){
            Vector3 kickDirection=this.transform.position-target.position;
            rb.AddForce(kickDirection*20);

        }
        private void enableRagdoll(){
            anim.enabled=false;
            rb.isKinematic=true;
            foreach(Rigidbody rbChild in childrb){
                rbChild.isKinematic=false;
            }

        }
        private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Sword")){
                isAlive=false;
                //kick();
                enableRagdoll();
                skinMesh.GetComponent<Renderer>().material=cutMaterial;
            
            }
            print("swoooooord");

        }

    }
}
