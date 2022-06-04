using UnityEngine;

namespace bridgrun.Scripts
{
    public class CharacterManager : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private BoxContainerController boxContainerController;
        [SerializeField]
        private string color;
        private bool canBuildStairs;
        public int currentEtape;
        public Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {
            rb = this.GetComponent<Rigidbody>();
            currentEtape = 0;
        
        
        
        
        
            color = "Yellow";
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Collectable"))
            {
                print("Yooo Collectable");




                other.gameObject.GetComponent<StairController>().popUP();
            
            
            
                boxContainerController.addNewStair(other.gameObject.transform);
            }
        
            if (other.gameObject.CompareTag("EnnemieBuildStairs"))
            {
                print("Yoooo Walking On Ennemie Build Stairs");
                canBuildStairs = getCurrentCollectedStairs() > 0;
                if (canBuildStairs)
                {
                
                
                
                    boxContainerController.removeStair();
                    other.gameObject.transform.parent.GetComponent<StairBuilderController>().addNewStairByPos(other.gameObject.transform.localPosition,this.color);
                    Destroy(other.gameObject);

                }
                else
                {
                    StairsManager.instance.makecollectables(currentEtape, false, this.color);

                    other.gameObject.transform.parent.GetComponent<StairBuilderController>().stopPlayerMoving(this.transform.position);
                }
            }
            if (other.gameObject.CompareTag("LevelEnd"))
            {
                GameManager.instance.endPlay();
                UiManager.instance.playerLoose();
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("index"))
            {
                canBuildStairs = getCurrentCollectedStairs() > 0;
                if (canBuildStairs)
                
                
                
                
                {
                    boxContainerController.removeStair();
                }
                else
                {
                    print("Player Want More Stair");

                    StairsManager.instance.makecollectables(currentEtape, false, this.color);
                }

            }        

        }
   
        public bool canBuild()
        {
            return canBuildStairs;
        }
        public int getCurrentCollectedStairs()
        {
            return boxContainerController.getTotalCollectedStairPices();
        }
        public void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Done"))
            {
                print("Player Win");
                GameManager.instance.endPlay();
            
            
            
            
                rb.isKinematic = true;
            
            
            
            
                UiManager.instance.playerWin();
            }
            if (other.gameObject.CompareTag("EndStaird"))
            {
                Destroy(other.gameObject);
                print("Stairs Checkout from " + color + " Ennemie");
                currentEtape++;
                StairsManager.instance.makecollectables(currentEtape, false, this.color);


            }
        }
        public string getColor()
        {
            return color;
        }


    }
}
