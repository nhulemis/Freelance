using UnityEngine;

namespace match3D.Scripts
{
    public class ObjectController : MonoBehaviour
    {
        Vector3 firstPos;
        Vector3 currentPos;
        Vector3 offset;
        Rigidbody rb;
        bool isDraging;
        
        
        bool placed;
        public bool inShootMode;
        public string name;
        private bool startDig;
        private int digSpeed=2;
        // Start is called before the first frame update
        void Start()
        {
            name=this.gameObject.name;
            rb=this.GetComponent<Rigidbody>();
            isDraging=false;
            placed=false;
        }

        // Update is called once per frame
        void Update()
        {
            if (startDig){
                this.transform.Translate(-Vector3.up * Time.deltaTime*digSpeed);

            }

        }
        private void OnMouseDown(){
            if (!inShootMode && canControll()) {

                print("Mouse Down");
                rb.useGravity = false;
                
                
                
                rb.isKinematic = false;
                firstPos = Input.mousePosition;
                Vector3 playerScreenPos = Camera.main.WorldToScreenPoint(this.transform.position);
                offset = playerScreenPos - firstPos;
            }

    	

        }
        private void OnMouseDrag(){
            if (!inShootMode && canControll())
            {
            
                currentPos = Input.mousePosition;
                isDraging = true;
                
                
                
                currentPos += offset;
                Vector3 newPos = Camera.main.ScreenToWorldPoint(currentPos);
                newPos = new Vector3(newPos.x, -9f, newPos.z);
                this.transform.position = Vector3.Lerp(this.transform.position, newPos, .4f);

            }
    	  
        }
        private void OnMouseUp(){
            if (!inShootMode && canControll())
            {
                rb.isKinematic = false;
                rb.useGravity = true;
                isDraging = false;
                
                
                
                print("Mouse Up");
            }
    	

        }
        private void OnTriggerStay(Collider other){
            if(other.gameObject.tag=="Base"){
                if(!isDraging && !placed){
                    placed=true;
                    MagnetManager.instance.place(this.transform);
                }
            }

        }
        private void OnTriggerExit(Collider other){
            if(other.gameObject.tag=="Base"){
                this.transform.parent=null;
                placed=false;
            
            }

        }
        public void enableshotMode() {
            rb.constraints = RigidbodyConstraints.None;

            print("Shooooooooot");
            inShootMode = true;
            rb.useGravity = true;
            isDraging = false;
            rb.AddForce(Vector3.forward * 500);
            Invoke("disableShootMode",5f);

        }
        private void disableShootMode() {
            inShootMode = false;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;



        }
        public void digDown(){
            startDig = true;
            Destroy(this.gameObject, 4f);
        }
        private bool canControll()
        {
            return GameManager.instance.canPlay();

        }



    }
}
