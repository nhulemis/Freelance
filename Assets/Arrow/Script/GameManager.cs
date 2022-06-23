using UnityEngine;

namespace Arrow.Script
{
    public class GameManager : MonoBehaviour
    {
        public enum GameState { play,end,wait};
        public GameState gameState;
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

        class HSUQOXkkoaw1
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUQOXkzkockosa2
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUcjiaojxjsi3
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class HSUckvoawopvp4
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }

        class CHusjxoacm6x
        {
            public static PlayerController instance;
            private GameObject head;
            public Camera mainCamera;
            public Transform FollowCam;
            private CameraController camController;
            public bool HitObstacle;
            public ArrowsController arrowController;
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        public void startPlay()
        {
            gameState = GameState.play;
            
            
            
            
        }
        public void looseGame()
        {
            gameState = GameState.end;
            Gameplay.Instance.finish();
            UiManager.instance.loose();
        }
        public void winGame()
        {
            UiManager.instance.win();

            gameState = GameState.end;
        }
    }
}
