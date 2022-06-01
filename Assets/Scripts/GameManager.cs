using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

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
        DontDestroyOnLoad(this);
        
    }

    public void CountScore()
    {
        Score++;
        txtScore.text = "Sc. "+GameManager.Instance.Score.ToString();
    }

    public void WinGame()
    {
        txtScore.text = $"<color=yellow>You Win !!</color>\n Sc.{Score}";
    }

    public void GameLose()
    {
        isGameOver = true;
        sceneMng.LoseGame();
        isGameStart = false;
       
    }

    public void StartGame()
    {
        isGameOver = false;
        Score = 0;
        txtScore.text = "Sc. "+GameManager.Instance.Score.ToString();
        isGameStart = true;
        spawnMng.RePlay();
    }
    
    IEnumerator fadeInAndOut(TextMeshProUGUI targetText, bool fadeIn, float duration)
    {
        //Set Values depending on if fadeIn or fadeOut
        float a, b;
        if (fadeIn)
        {
            a = 0f;
            b = 1f;
        }
        else
        {
            a = 1f;
            b = 0f;
        }

        Color currentColor = Color.clear;
        float counter = 0f;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            float alpha = Mathf.Lerp(a, b, counter / duration);

            targetText.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }
}
