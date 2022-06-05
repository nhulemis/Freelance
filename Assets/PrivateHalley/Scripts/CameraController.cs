using UnityEngine;

namespace PrivateHalley.Scripts
{
    public class CameraController : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset;
        public bool rotate;
        private bool stop=false;
        public static CameraController instance;
        
        
        void Awake(){
            if(instance==null){
                
                
                
                
                
                
                
                
                
                instance=this;

            }else if(instance!=this){
                
                
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            offset=target.position-this.transform.position;
            offset=-offset;
        
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
        void FixedUpdate()
        {
            if(!rotate ){
                if(!stop){
                    Vector3 newPos=target.position+offset;
                    this.transform.position=Vector3.Slerp(transform.position,newPos,.5f);
                }
           
            }else {
                transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);

            }
    	
        }
        public void startRotatingu(){
            rotate=true;
        }
        public void stopFollowingk(){
            stop=true;
        }

    }
}
