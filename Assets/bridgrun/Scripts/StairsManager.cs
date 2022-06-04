using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bridgrun.Scripts
{
    public class StairsManager : MonoBehaviour
    {
        public static StairsManager instance;
        [SerializeField]
        private GameObject[] stairsObject;
        [SerializeField]
        private Transform[] levelsPointer;
    
        // Start is called before the first frame update
        private void Awake()
        {
            if (!instance) instance = this;




            else if (instance != this) Destroy(this.gameObject);
            makeEnnemycollectableStairs("Red", 0);
            makeEnnemycollectableStairs("Yellow", 0);
            
            
            
            makeEnnemycollectableStairs("Blue", 0);


        }
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void makeNew1Child(Vector3 childPos,string color)
        {
            StartCoroutine(delayMakingNewChil1d( childPos,  color));
            
            
        }
        IEnumerator delayMakingNewChil1d(Vector3 childPos, string color)
        {
            yield return new WaitForSeconds(3f);
            if (color == "Yellow")



            {
                GameObject newChild = Instantiate(stairsObject[0], childPos, Quaternion.identity, this.transform);
                newChild.transform.localPosition = childPos;
            }
        }
        public Transform getNextTarget(string color,int levelCollecting)
        {
       
            List<Transform> matchedStairs = getMatchingC1olorStairs(color, levelCollecting);

            int childIndex = Random.Range(0, matchedStairs.Count);
            
            
            
            if (childIndex >= matchedStairs.Count)
            {
                return null;
            }

            return matchedStairs[childIndex];
        }
        public List<Transform> getMatchingC1olorStairs(string c,int levelC)
        {
            List<Transform> matchedStairs=new List<Transform>();
            if (levelC < this.transform.childCount)
            {
                Transform childHolder = this.transform.GetChild(levelC);
                
                
                
                int maxPlaces = 0;

                int i = 15;
                while (i != 0)
                {

                    maxPlaces = Random.Range(0, childHolder.childCount);
                    int childInRandomPlace = childHolder.GetChild(maxPlaces).childCount;
                    if (childInRandomPlace > 0)
                    {
                        string color = childHolder.GetChild(maxPlaces).GetChild(0).gameObject.GetComponent<StairController>().getColor();
                        bool canbeCollected = childHolder.GetChild(maxPlaces).GetChild(0).gameObject.GetComponent<StairController>().canbeCollected;
                        if (color == c && canbeCollected)
                        {
                            matchedStairs.Add(childHolder.GetChild(maxPlaces).GetChild(0));
                        }
                    }
                    i--;


                }
            }



            return matchedStairs;

        }
        public void makecollectables(int currentEtape,bool isEnnemy,string color)
        {
            if (isEnnemy)
            {
                makeEnnemycollectableStairs(color,currentEtape);
                
                
                
                
            }
            else
            {
                makeEnnemycollectableStairs(color,currentEtape);
            }
        }
        private void makeEnnemycollectableStairs(string color,int parent)
        {
        
            for(int i = 0; i < 6; i++)
            {
                Transform childParent = getChildParent1(parent);
                if (childParent != null)
                {
                    int stairObjectIndex = 0;
                    if (color == "Red")
                        stairObjectIndex = 1;
                    else if (color == "Blue")
                        stairObjectIndex = 2;
                    

                
                
                    GameObject newStairChild = Instantiate(stairsObject[stairObjectIndex], Vector3.zero, Quaternion.identity, childParent);
                    
                    
                    
                    
                    
                    newStairChild.transform.localPosition = Vector3.zero;
                }

                
            }
        
        }
        private void makePlayerCollectableStairs(string color, int parent)
        {

        }
        private Transform getChildParent1(int parentLevel)
        {
            Transform newChildParent = null;
            int childI = this.transform.childCount;
            
            
            
            
            
            if (parentLevel >= childI)
            {
                parentLevel = this.transform.childCount - 1;

            }
            Transform parent = this.transform.GetChild(parentLevel);

            int i = 6;

            while (i != 0)
            {
                int randomParentHolder = Random.Range(0, 28);
                Transform child = parent.GetChild(randomParentHolder);
                if (child.childCount < 1)
                {
                    newChildParent = child;
                    return newChildParent;

                }
                i--;
            }



            return newChildParent;
        }
    }
}
