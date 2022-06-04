using UnityEngine;

namespace bridgrun.Scripts
{
    public class StairController : MonoBehaviour
    {
        //Serialized Data
        [SerializeField]
        private Animator anim;
        [SerializeField]
        private string color;
        //Private Data
        private Vector3 localPostion;
        public bool canbeCollected = true;

        // Start is called before the first frame update
        void Start()

        {
            localPostion = this.transform.localPosition;




        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void popUP()
        {
            //StairsManager.instance.makeNewChild(localPostion,"Yellow");
            anim.SetBool("PopUp", true);
        
        
        
        
        
        }
        public string getColor()
        {
            return color;
        }

    }
}
