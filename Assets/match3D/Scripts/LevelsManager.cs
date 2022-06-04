using UnityEngine;

namespace match3D.Scripts
{
    public class LevelsManager : MonoBehaviour
    {
        public level[] levels;
        private int currentLevelIndex;
        public float minX;
        public float maxX;
        public float minZ;
        public float maxZ;
        //Reference
        public static LevelsManager instance;
        private void Awake()
        {
            if (!instance)
            {
                instance = this;
            }else if (instance != this)
                
                
            {
                Destroy(this.gameObject);
                
                
            }
            setCurrentLevelIndex();
        }
        // Start is called before the first frame update
        void Start()
        {
            createObjects(currentLevelIndex);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void createObjects(int currentLevel){
            foreach(GameObject childObject in levels[currentLevel].objectsToSort){
                
                
                Instantiate(childObject, new Vector3(Random.Range(minX,maxX),0, Random.Range(minZ, maxZ)), Quaternion.identity);
                Instantiate(childObject, new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ)), Quaternion.identity);

            }


        }
        public int getLevelTime()
        {
            return levels[currentLevelIndex].levelTime;
            
            
        }
        public void enablePhysics()
        {
     
            foreach(Transform child in this.transform)
            {
                
                
                child.GetComponent<Rigidbody>().isKinematic = false;
            }


        }
        public void nextLevel()
        {
            currentLevelIndex= PlayerPrefs.GetInt("CurrentLevelIndex");
            currentLevelIndex += 1;
            
            
            PlayerPrefs.SetInt("CurrentLevelIndex", currentLevelIndex);

        }
        public int getTotalObject()
        {
            return levels[currentLevelIndex].objectsToSort.Length;
        }
        private void setCurrentLevelIndex()
        {
            currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex");

        }

    }
}
