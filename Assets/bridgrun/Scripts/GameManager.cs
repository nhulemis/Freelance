﻿using UnityEngine;

namespace bridgrun.Scripts
{
    public class GameManager : MonoBehaviour
    {
        //Reference
        public enum GameState { wait,play,end};
        public  GameState currentGameState;
        public static GameManager instance;


        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);



        }
        // Start is called before the first frame update
        void Start()
        {
            //  startPlay()
            ;   }

        // Update is called once per frame
        void Update()
        {
        
        }
        public  void startPlay()
        {
            currentGameState = GameState.play;
        }
        public  void endPlay()
        {
            currentGameState = GameState.end;
        }
    
    }
}
