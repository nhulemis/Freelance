using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField]
        private Cards[] levelsData;
        //Private
        public string levelName;
        //Reference
        public static LevelManager instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {
            levelName = getConceptName();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public Cards getCurrentLevelData()
        {
            int currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex");
            if (currentLevelIndex >= levelsData.Length)
                currentLevelIndex = 0;
            return levelsData[currentLevelIndex];
        }
        public Sprite[] getCurrentLevelSprite(int avatarIndex)
        {
            Sprite[] data =new Sprite[1];
            int currentLevelIndex = getCurrentLevelIndex();

            if (avatarIndex== 0)
            {
                data= levelsData[currentLevelIndex].retriveTshirtItems();
            }
            else if (avatarIndex==1)
            {
                data = levelsData[currentLevelIndex].retriveshoesItems();
            }
            else if (avatarIndex == 2)
            {
                data = levelsData[currentLevelIndex].retriveSkirtItems();

            }
            else if (avatarIndex == 3)
            {
                data = levelsData[currentLevelIndex].retriveHairItems();

            }
            else if (avatarIndex == 4)
            {
                data = levelsData[currentLevelIndex].retrivePontalonItems();

            }
            else if (avatarIndex == 5)
            {
                data = levelsData[currentLevelIndex].retriveGlassesItems();

            }
            else if (avatarIndex == 6)
            {
                data = levelsData[currentLevelIndex].retriveneckLessItems();

            }
            else if (avatarIndex == 7)
            {
                data = levelsData[currentLevelIndex].retriveGloves();

            }
            return data;
        }
        public string getConceptName()
        {
            int currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex");

            return levelsData[currentLevelIndex].concepttemName;
        }
        public int getCurrentLevelIndex()
        {
            return PlayerPrefs.GetInt("CurrentLevelIndex");

        }
    
    }
}
