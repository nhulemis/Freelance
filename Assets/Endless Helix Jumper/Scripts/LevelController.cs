using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public static LevelController instance;

	public Text scoreText;
	public GameObject gameOverPanel;
	public bool gameOver;

	private int score;
	private void Awake()
	{
		instance = this;
	}

  private void Start()
  {
    
    GameItemManager.Instance.AddCoinDaily();
  }

  class ABCulkjasd
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkai
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkailjzxjklckjla
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class jkzcvjkaiopizxckla
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
  class OICUjkhakjxka
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }


  public void SetScore()
	{
		score++;
		if(scoreText != null)
			scoreText.text = score.ToString();
	}

	public void GameOver()
	{
    GameItemManager.Instance.UseCoin(1);
		if(gameOverPanel != null)
			gameOverPanel.SetActive(true);

		gameOver = true;
	}

  class ABCu
  {
    private int a;
    private int b;
    private float c;
    private bool d;
    
  }
	public void ReloadScene()
	{
    if (!GameItemManager.Instance.IsEnoughCoin())
    {
      return;
    }
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
