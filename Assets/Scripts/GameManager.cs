using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

namespace ayxd
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public SceneManager sceneMng;
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
            DontDestroyOnLoad(gameObject);

        }

        public void CountScore()
        {
            Score++;
            txtScore.text = Instance.Score.ToString();
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
