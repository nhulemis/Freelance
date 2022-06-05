using UnityEngine;

namespace PrivateHalley.Scripts
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
        }
        public class ShoppingCartItem
        {
            private int productID;
            private string productCategory;
            private string subCategory;
            private string productName;
            private string productDescription;
            private decimal productPrice;
            private double productWeight;
            private int units;

            public int ProductID
            {
                get { return productID; }
            }
            public string ProductCategory
            {
                get { return productCategory; }
            }
            public string SubCategory
            {
                get { return subCategory; }
            }
            public string ProductName
            {
                get { return productName; }
            }
            public string ProductDescription
            {
                get { return productDescription; }
            }
            public decimal ProductPrice
            {
                get { return productPrice; }
            }
            public double ProductWeight
            {
                get { return productWeight; }
                set { productWeight = value; }
            }
            public int Units
            {
                get { return units; }
                set { units = value; }
            }
            public decimal Total
            {
                get { return Units * ProductPrice; }
            }
            public ShoppingCartItem(int productID, string farm, string productCategory, 
                string subCategory, string productName, string productDescription,
                decimal productPrice, double productWeight, int units)
            {
                this.productID = productID;
                this.productCategory = productCategory;
                this.subCategory = productCategory;
                this.productName = productName;
                this.productDescription = productDescription;
                this.productPrice = productPrice;
                this.productWeight = productWeight; 
                this.units = units;
            }
        }
        // Update is called once per frame
        void Update()
        {
            // switch(GameManager.instance.currentState){
            //     case GameManager.GameState.play :
            //         if(isAlive){
            //             this.transform.LookAt(target.position);
            //             transform.eulerAngles=new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
            //             float distanceToTarget=Vector3.Distance(target.position,this.transform.position);
            //             //print("DISTANCE tO target IS : "+distanceToTarget);
            //             if(Time.time>lastTimeShoot+3f && distanceToTarget<distanceToShoot){
            //                 shoot();
            //                 lastTimeShoot=Time.time;
            //
            //             }
            //
            //         }
            //
            //         break;
            // }
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

        }

    }
}
