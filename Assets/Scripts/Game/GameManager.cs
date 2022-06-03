using TMPro;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public SceneMng sceneMng;
        public bool isGameOver;

        public bool isGameStart;
        public SpawnManager spawnMng;
        public TextMeshProUGUI txtScore;
        public int Score;
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
            }

            Instance = this;
            DontDestroyOnLoad(this);
        
        }

        public void CountScore()
        {
            Score++;
            //txtScore. = GameManager.Instance.Score.ToString();
        }

        public void GameLose()
        {
            isGameOver = true;
            sceneMng.LoseGame();
            isGameStart = false;
            // spawnMng.RePlay();
        }

        public void StartGame()
        {
            isGameOver = false;
            Score = 0;
            isGameStart = true;
            spawnMng.RePlay();
        }
    }
}