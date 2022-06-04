using UnityEngine;

namespace bridgrun.Scripts
{
    public class StairBuilderController : MonoBehaviour
    {
        [SerializeField]
        GameObject[] stairObject;
        [SerializeField]
        GameObject stoper;
        private Vector3 currentStairPos=new Vector3(.2f,.5f,-0.03f);
        private Vector3 offset=new Vector3(0,.3f,1f);
        // Start is called before the first frame update
        void Start()
        {
            currentStairPos = new Vector3(.2f, .25f, -0.03f);
            offset = new Vector3(0, .4f, 1f);
            disablePlayerStoper();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void addNewStair(string Color)
        {
            int stairIndex = 0;
            if (Color == "Red")
            {
                stairIndex = 1;
            }else if (Color == "Blue")
            {
                stairIndex = 2;
            }
            GameObject stairObj= Instantiate(stairObject[stairIndex], Vector3.zero, Quaternion.identity, this.transform);
            stairObj.transform.localPosition = currentStairPos;
            currentStairPos += offset;

        }
        public void addNewStairByPos(Vector3 position,string color)
        {
            int stairIndex = 0;
            if (color == "Red")
            {
                stairIndex = 1;
            }
            else if (color == "Blue")
            {
                stairIndex = 2;
            }
            GameObject stairObj = Instantiate(stairObject[stairIndex], Vector3.zero, Quaternion.identity, this.transform);
            stairObj.transform.localPosition = position;

        }
        public void stopPlayerMoving(Vector3 playerPos)
        {
            stoper.SetActive(true);
            stoper.transform.position = playerPos;

        }
        public void disablePlayerStoper()
        {
            stoper.SetActive(false);

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                disablePlayerStoper();
            }
        }

    }
}
