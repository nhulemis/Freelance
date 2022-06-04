using UnityEngine;

namespace match3D.Scripts
{
    public class MagnetManager : MonoBehaviour
    {
        [SerializeField]
        Transform rightPlace;
        [SerializeField]
        Transform leftPlace;
        [SerializeField]
        Transform middlePoint;

        [SerializeField]
        Animator rightLidAnim;
        [SerializeField]
        Animator leftLidAnim;

        int totalObjectToMatch;
        int rChildNum;
        int lChildNum;
        public static MagnetManager instance;
        void Awake(){
            if(!instance){
                instance=this;
            }else if(instance!=this){
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            totalObjectToMatch = LevelsManager.instance.getTotalObject();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void OnTriggerEnter(Collider other){
            print("Magnet Trigger");

        }
        public void place(Transform newChild){
            if(canPlace()){
                if(rChildNum<1){
       

                    newChild.parent=rightPlace;
                    
                    
                    newChild.localPosition=new Vector3(0,1,0);
                    newChild.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    newChild.transform.eulerAngles = Vector3.zero;

                }
                else{
                    if (canBeAdjacent(newChild))
                    {
                        AudioManager.instance.playMergeSucceded();
                        newChild.parent = leftPlace;
                        newChild.localPosition = new Vector3(0, 1, 0);
                        
                        
                        newChild.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        newChild.transform.eulerAngles = Vector3.zero;

                    }
                    else {
                        newChild.GetComponent<ObjectController>().enableshotMode();
                        AudioManager.instance.playMergeFailed();
                        print("sHOOT oBJECT");

                    }

                
    			

                }
                checkForsimilaritie();

            }


        }
        private void checkForsimilaritie(){
            if(!canPlace()){
                string name1=rightPlace.GetChild(0).GetComponent<ObjectController>().name;
                string name2=leftPlace.GetChild(0).GetComponent<ObjectController>().name;
                if(name1==name2){
                    print("Same Object");
                    UiManager.instance.animateCoin(middlePoint);
                    rightLidAnim.SetBool("OpenHill",true);
                    
                    
                    leftLidAnim.SetBool("OpenHill",true);
                    Invoke("objectMatches", .2f);
                }else{
                    print("Please Choose Distunct objects");

                }

            }
        }
        private bool canBeAdjacent(Transform other){
            bool canPlace = false;
            if (rightPlace.childCount > 0){
                string name1 = rightPlace.GetChild(0).GetComponent<ObjectController>().name;
                string name2 = other.GetComponent<ObjectController>().name;
                if (name1 == name2){
                    canPlace = true;

                }


           

            }


            return canPlace;
        }

        private bool canPlace(){
            bool place=false;
            rChildNum=rightPlace.childCount;
            lChildNum=leftPlace.childCount;
            if(rChildNum<1 || lChildNum<1)
                place=true;

            return place;
        }
        private void objectMatches(){
            if (!canPlace()) {
                rightLidAnim.SetBool("OpenHill",false);
                leftLidAnim.SetBool("OpenHill", false);

                Transform right = rightPlace.GetChild(0);
                Transform left = leftPlace.GetChild(0);
                right.parent = null;
                left.parent = null;
                right.position =middlePoint.position;
                left.position = middlePoint.position;
                right.GetComponent<ObjectController>().digDown();
                left.GetComponent<ObjectController>().digDown();
                UiManager.instance.matchedObject();
                totalObjectToMatch--;
                if (totalObjectToMatch <= 0)
                {
                    UiManager.instance.winGame();
                }

            }

        }
        public void assignTotalObjects(int value){
            totalObjectToMatch = value;

        }


    }
}
