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
    GameItemManager.Instance.AddCoinDaily();
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

	public void ReloadScene()
	{
    if (!GameItemManager.Instance.IsEnoughCoin())
    {
      return;
    }
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
