using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public UIManager uIManager;

	public ScoreManager scoreManager;

	[Header("Game settings")]
	public GameObject player;

	public GameObject gameOverlay;

	[Space(5f)]
	public GameObject smasherPrefab;

	[Space(5f)]
	public int minNumberOfSmashers = 5;

	public int maxNumberOfSmashers = 10;

	[Space(5f)]
	public List<GameObject> upSmashers;

	[Space(5f)]
	public List<GameObject> bottomSmashers;

	[Space(5f)]
	public float moveDistance;

	[Space(5f)]
	public float smasherMoveSpeed;

	public bool canMove;

	public List<float> smashersStartPositions;

	public List<float> smashersTargetPositions;

	private GameObject lastSmasher;

	private Vector3 screenSize;

	private int indexShorterSmasher;

	private int currentPosition;

	private int numOfSmashers;

	private bool position;

	public static GameManager Instance
	{
		get;
		set;
	}

	private void Awake()
	{
		//Object.DontDestroyOnLoad(this);
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private void Start()
	{
		Physics2D.gravity = new Vector2(0f, 0f);
		Application.targetFrameRate = 30;
		screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
		StartCoroutine(CreateScene());
	}

	private void Update()
	{
		if (uIManager.gameState == GameState.PLAYING && Input.GetMouseButtonDown(0) && canMove)
		{
			if (uIManager.IsButton())
			{
				return;
			}
			if (UnityEngine.Input.mousePosition.x > (float)Screen.width * 0.5f)
			{
				if (currentPosition < numOfSmashers)
				{
					currentPosition++;
					AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
				}
			}
			else if (currentPosition > 0)
			{
				currentPosition--;
				AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
			}
			if (currentPosition >= numOfSmashers)
			{
				currentPosition = numOfSmashers - 1;
			}
			canMove = false;
			player.transform.position = new Vector2(bottomSmashers[currentPosition].transform.position.x, bottomSmashers[currentPosition].transform.position.y + bottomSmashers[currentPosition].transform.localScale.y / 2f + player.GetComponent<SpriteRenderer>().size.y / 2f);
		}
		if (uIManager.gameState == GameState.MOVINGSMASHERS)
		{
			for (int i = 0; i < upSmashers.Count; i++)
			{
				upSmashers[i].transform.position = Vector2.Lerp(upSmashers[i].transform.position, new Vector2(upSmashers[i].transform.position.x, smashersTargetPositions[i]), smasherMoveSpeed);
			}
			if (Mathf.Abs(upSmashers[0].transform.position.y - smashersTargetPositions[0]) < 0.001f)
			{
				for (int j = 0; j < upSmashers.Count; j++)
				{
					upSmashers[j].transform.position = new Vector2(upSmashers[j].transform.position.x, smashersTargetPositions[j]);
				}
				position = !position;
				if (!position)
				{
					StartCoroutine(NewScene());
					return;
				}
				currentPosition = UnityEngine.Random.Range(0, numOfSmashers);
				player.transform.position = new Vector2(bottomSmashers[currentPosition].transform.position.x, bottomSmashers[currentPosition].transform.position.y + bottomSmashers[currentPosition].transform.localScale.y / 2f + player.GetComponent<SpriteRenderer>().size.y / 2f);
				ShowPlayer();
				if (uIManager.mainMenuGui.activeInHierarchy)
				{
					uIManager.gameState = GameState.MENU;
				}
				else
				{
					StartCoroutine(SlideDown());
					uIManager.gameState = GameState.PLAYING;
				}
			}
		}
		if (uIManager.gameState == GameState.PLAYING && Input.GetMouseButtonUp(0))
		{
			canMove = true;
		}
	}

	public void OnHomeClicked()
	{
		StartCoroutine(Restart(startGame: false));
	}

	private IEnumerator CreateScene()
	{
		HidePlayer();
		position = false;
		uIManager.gameState = GameState.CREATINGSCENE;
		numOfSmashers = UnityEngine.Random.Range(minNumberOfSmashers, maxNumberOfSmashers + 1);
		float num = screenSize.x * 2f / (float)numOfSmashers;
		indexShorterSmasher = UnityEngine.Random.Range(0, numOfSmashers);
		for (int i = 0; i < numOfSmashers; i++)
		{
			float num2 = UnityEngine.Random.Range(screenSize.y - 0.6f * screenSize.y, screenSize.y - 0.2f * screenSize.y);
			lastSmasher = UnityEngine.Object.Instantiate(smasherPrefab);
			lastSmasher.transform.localScale = new Vector2(num, num2);
			lastSmasher.transform.position = new Vector2(0f - screenSize.x + ((float)i + 0.5f) * num, 0f - screenSize.y + num2 / 2f);
			bottomSmashers.Add(lastSmasher);
		}
		for (int j = 0; j < numOfSmashers; j++)
		{
			float num2 = 2f * screenSize.y - bottomSmashers[j].gameObject.transform.localScale.y;
			lastSmasher = UnityEngine.Object.Instantiate(smasherPrefab);
			lastSmasher.transform.localScale = new Vector2(num, num2);
			if (j == indexShorterSmasher)
			{
				lastSmasher.transform.position = new Vector2(0f - screenSize.x + ((float)j + 0.5f) * num, bottomSmashers[j].transform.position.y + bottomSmashers[j].transform.localScale.y / 2f + lastSmasher.transform.localScale.y / 2f + 1f);
			}
			else
			{
				lastSmasher.transform.position = new Vector2(0f - screenSize.x + ((float)j + 0.5f) * num, bottomSmashers[j].transform.position.y + bottomSmashers[j].transform.localScale.y / 2f + lastSmasher.transform.localScale.y / 2f);
			}
			smashersStartPositions.Add(lastSmasher.transform.position.y);
			smashersTargetPositions.Add(lastSmasher.transform.position.y + moveDistance);
			upSmashers.Add(lastSmasher);
		}
		AudioManager.Instance.PlayEffects(AudioManager.Instance.slide);
		uIManager.gameState = GameState.MOVINGSMASHERS;
		yield return new WaitForSeconds(0.1f);
		gameOverlay.GetComponent<Animator>().Play("GameOverlayHide");
	}

	public void Slide()
	{
		StartCoroutine(SlideDown());
	}

	private IEnumerator NewScene()
	{
		uIManager.gameState = GameState.CREATINGSCENE;
		ScoreManager.Instance.UpdateScore(1);
		yield return new WaitForSeconds(0.6f);
		ClearScene();
		StartCoroutine(CreateScene());
	}

	private IEnumerator SlideDown()
	{
		AudioManager.Instance.PlayEffects(AudioManager.Instance.counter);
		for (int i = 0; i < numOfSmashers; i++)
		{
			smashersTargetPositions[i] = smashersStartPositions[i];
		}
		yield return new WaitForSeconds(3.5f);
		AudioManager.Instance.PlayEffects(AudioManager.Instance.slide);
		uIManager.gameState = GameState.MOVINGSMASHERS;
	}

	public void ShowPlayer()
	{
		player.gameObject.GetComponent<SpriteRenderer>().enabled = true;
		player.gameObject.GetComponent<CircleCollider2D>().enabled = true;
	}

	public void HidePlayer()
	{
		player.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		player.gameObject.GetComponent<CircleCollider2D>().enabled = false;
	}

	public void RestartGame()
	{
		StartCoroutine(Restart(startGame: true));
	}

	private IEnumerator Restart(bool startGame)
	{
		gameOverlay.GetComponent<Animator>().Play("GameOverlayShow");
		yield return new WaitForSeconds(0.6f);
		if (startGame)
		{
			uIManager.ShowGameplay();
		}
		ClearScene();
		scoreManager.ResetCurrentScore();
		StartCoroutine(CreateScene());
	}

	public void ClearScene()
	{
		smashersStartPositions.Clear();
		smashersTargetPositions.Clear();
		upSmashers.Clear();
		bottomSmashers.Clear();
		GameObject[] array = GameObject.FindGameObjectsWithTag("Obstacle");
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.Destroy(array[i]);
		}
	}

	public void GameOver()
	{
		if (uIManager.gameState == GameState.PLAYING || uIManager.gameState == GameState.MOVINGSMASHERS)
		{
			StopAllCoroutines();
			AudioManager.Instance.PlayEffects(AudioManager.Instance.gameOver);
			AudioManager.Instance.PlayEffects(AudioManager.Instance.smash);
			AudioManager.Instance.PlayMusic(AudioManager.Instance.menuMusic);
			uIManager.ShowGameOver();
			player.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			scoreManager.UpdateScoreGameover();
		}
	}
}
