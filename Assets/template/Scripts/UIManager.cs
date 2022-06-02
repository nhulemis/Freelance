using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using game_sub;

public class UIManager : MonoBehaviour
{
	[Header("GUI Components")]
	public GameObject mainMenuGui;

	public GameObject pauseGui;

	public GameObject gameplayGui;

	public GameObject gameOverGui;

	public GameState1 gameState;

	private bool clicked;

	private void Start()
	{
		mainMenuGui.SetActive(value: true);
		pauseGui.SetActive(value: false);
		gameplayGui.SetActive(value: false);
		gameOverGui.SetActive(value: false);
		gameState = GameState1.MENU;
	}
	

	public void convert()
	{
		float fValue = 0.123456f;
		int iValue = (int)fValue;
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.FloorToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.CeilToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.RoundToInt(fValue);
		Debug.Log("int val: " +iValue);
	}
	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && gameState == GameState1.MENU && !clicked)
		{
			if (!IsButton())
			{
				AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
				ShowGameplay();
				GameManager.Instance.readyToShoot = false;
			}
		}
		else if (Input.GetMouseButtonUp(0) && clicked && gameState == GameState1.MENU)
		{
			clicked = false;
		}
	}

	public void ShowMainMenu()
	{
		ScoreManager.Instance.ResetCurrentScore();
		clicked = true;
		mainMenuGui.SetActive(value: true);
		pauseGui.SetActive(value: false);
		gameplayGui.SetActive(value: false);
		gameOverGui.SetActive(value: false);
		if (gameState == GameState1.PAUSED)
		{
			Time.timeScale = 1f;
		}
		gameState = GameState1.MENU;
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		GameManager.Instance.ClearScene();
		GameManager.Instance.CreateScene();
	}

	public void ShowPauseMenu()
	{
		if (gameState != GameState1.PAUSED)
		{
			pauseGui.SetActive(value: true);
			Time.timeScale = 0f;
			gameState = GameState1.PAUSED;
			AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		}
	}

	public void HidePauseMenu()
	{
		pauseGui.SetActive(value: false);
		Time.timeScale = 1f;
		gameState = GameState1.PLAYING;
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
	}

	public void ShowGameplay()
	{
		mainMenuGui.SetActive(value: false);
		pauseGui.SetActive(value: false);
		gameplayGui.SetActive(value: true);
		gameOverGui.SetActive(value: false);
		gameState = GameState1.PLAYING;
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
	}

	public void ShowGameOver()
	{
		mainMenuGui.SetActive(value: false);
		pauseGui.SetActive(value: false);
		gameplayGui.SetActive(value: false);
		gameOverGui.SetActive(value: true);
		gameState = GameState1.GAMEOVER;
	}

	public bool IsButton()
	{
		bool flag = false;
		PointerEventData eventData = new PointerEventData(EventSystem.current)
		{
			position = UnityEngine.Input.mousePosition
		};
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventData, list);
		foreach (RaycastResult item in list)
		{
			flag |= (item.gameObject.GetComponent<Button>() != null);
		}
		return flag;
	}
}
