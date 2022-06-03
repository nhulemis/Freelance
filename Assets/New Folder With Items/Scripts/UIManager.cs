using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	[Header("GUI Components")]
	public GameObject mainMenuGui;

	public GameObject gameplayGui;

	public GameObject gameOverGui;

	public GameState gameState;

	private bool clicked;

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
	private void Start()
	{
		mainMenuGui.SetActive(value: true);
		gameplayGui.SetActive(value: false);
		gameOverGui.SetActive(value: false);
		gameState = GameState.MENU;
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && gameState == GameState.MENU && !clicked)
		{
			if (!IsButton())
			{
				ShowGameplay();
				GameManager.Instance.Slide();
			}
		}
		else if (Input.GetMouseButtonUp(0) && clicked && gameState == GameState.MENU)
		{
			clicked = false;
		}
	}

	public void ShowMainMenu()
	{
		// ScoreManager.Instance.ResetCurrentScore();
		// clicked = true;
		// mainMenuGui.SetActive(value: true);
		// gameplayGui.SetActive(value: false);
		// gameOverGui.SetActive(value: false);
		// gameState = GameState.MENU;
		// AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		// GameManager.Instance.OnHomeClicked();
	}

	public void ShowGameplay()
	{
		mainMenuGui.SetActive(value: false);
		gameplayGui.SetActive(value: true);
		gameOverGui.SetActive(value: false);
		gameState = GameState.PLAYING;
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		AudioManager.Instance.PlayMusic(AudioManager.Instance.gameMusic);
		GameManager.Instance.canMove = true;
	}

	public void ShowGameOver()
	{
		mainMenuGui.SetActive(value: false);
		gameplayGui.SetActive(value: false);
		gameOverGui.SetActive(value: true);
		gameState = GameState.GAMEOVER;
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
