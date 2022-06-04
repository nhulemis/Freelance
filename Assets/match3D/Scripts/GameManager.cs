using UnityEngine;

namespace match3D.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public enum GameState { play,end,wait};
        public GameState currentState;
        public static GameManager instance;

        private void Awake()
        {
            if (!instance) instance = this;
            
            
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void startPlay(){
            currentState = GameState.play;

        }
        public void endPlay()
        {
            currentState = GameState.end;


        }
        public bool canPlay()
        {
            
            
            return currentState == GameState.play;
            
            
        }
    

    }
}
