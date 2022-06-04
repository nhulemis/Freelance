using UnityEngine;

namespace hairmaster.Scripts
{
    public class PlayerPointController : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] characters;
        private int selectedCharacterIndex;
        public static PlayerPointController instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharactere");
            
            
            
        
            Instantiate(characters[selectedCharacterIndex], this.transform.position, Quaternion.identity);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public Vector3 getPos()
        {
            
            
            return this.transform.position;
        }
    }
}
