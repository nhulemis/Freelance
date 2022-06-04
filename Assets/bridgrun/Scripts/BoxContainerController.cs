using System.Collections;
using UnityEngine;

namespace bridgrun.Scripts
{
    public class BoxContainerController : MonoBehaviour
    {
        private Vector3 stdLocalScale=new Vector3(0.015f, 0.005f, 0.01f);
        private Vector3 stdOffset=new Vector3(0, 0.004f,0);
        public Vector3 currentChildPos;
        public float waitTime=.3f; 
         
        // Start is called before the first frame update
        void Start()
        {
            currentChildPos = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void addNewStair(Transform newChild)
        {

            StartCoroutine(delayNewStair(newChild));
        }
        IEnumerator delayNewStair(Transform newChild)
        {
            yield return new WaitForSeconds(waitTime);
            newChild.parent = this.transform;
        
        
        
        
            newChild.localPosition = currentChildPos;



            newChild.localScale = stdLocalScale;
            newChild.localEulerAngles = Vector3.zero;
            currentChildPos += stdOffset;

        }
        public int getTotalCollectedStairPices()
        {
            return this.transform.childCount;
        }
        public void removeStair()
        {
            int childCount = getTotalCollectedStairPices();
            if (childCount >= 0)
            {
                print("Remove Offset");
                currentChildPos -= stdOffset;
                Destroy(this.transform.GetChild(childCount - 1).gameObject);
            }
       
        }
    }
}
