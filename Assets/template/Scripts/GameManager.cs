using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace template.Scripts
{
    
public class GameManager : MonoBehaviour
{
	public UIManager uIManager;

	public ScoreManager scoreManager;

	[Header("Game settings")]
	[Space(5f)]
	public GameObject camObject;

	[Space(5f)]
	public GameObject player;

	[Space(5f)]
	public int playerSpeed;

	[Space(5f)]
	public Color[] colorTable;

	[Space(5f)]
	public GameObject obstaclePrefab;

	[Space(5f)]
	public float yMinDistanceBetweenObstacles = 5f;

	[Space(5f)]
	public float yMaxDistanceBetweenObstacles = 10f;

	[Space(5f)]
	public float maxXDistanceNextObstacle = 5f;

	[Space(5f)]
	public int deltaObstacle = 3;

	[Space(5f)]
	public bool readyToShoot;

	private GameObject nextObstacle;

	private GameObject tempObstacle;

	private Color tempColor;

	private int obstacleId;

	public bool movingPlayer;

	public bool shooting;

	private float step;

	private Vector2 flyDestination;

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
		step = (float)playerSpeed * Time.deltaTime;
		CreateScene();
	}

	private void Update()
	{
		if ((uIManager.gameState == GameState1.PLAYING && Input.GetMouseButtonDown(0) && uIManager.IsButton()) || uIManager.gameState != GameState1.PLAYING)
		{
			return;
		}
		if (movingPlayer)
		{
			player.transform.position = Vector2.MoveTowards(player.transform.position, flyDestination, step);
			if (Vector2.Distance(player.transform.position, flyDestination) < 0.001f)
			{
				movingPlayer = false;
				readyToShoot = false;
				flyDestination = tempObstacle.transform.position;
			}
		}
		else if (readyToShoot && !movingPlayer && !shooting)
		{
			MovePlayer();
		}
		else if (Input.GetMouseButton(0) && !shooting && !movingPlayer)
		{
			shooting = true;
			StartCoroutine(ShotBall());
		}
	}

	public void CreateScene()
	{
		ResetPlayerAnimation();
		obstacleId = 0;
		tempColor = colorTable[Random.Range(0, colorTable.Length)];
		player.GetComponent<SpriteRenderer>().color = tempColor;
		nextObstacle = UnityEngine.Object.Instantiate(obstaclePrefab);
		nextObstacle.transform.position = new Vector2(0f, -3f);
		tempObstacle = UnityEngine.Object.Instantiate(obstaclePrefab);
		tempObstacle.transform.position = new Vector2(0f, 3f);
		player.GetComponent<Player>().targetPos = tempObstacle.transform.position;
		flyDestination = tempObstacle.transform.position;
		nextObstacle.GetComponent<Obstacle>().SetObstacle(tempColor, obstacleId, 0);
		nextObstacle.GetComponent<Obstacle>().SetNextObstaclePosition(tempObstacle.transform.position);
		obstacleId++;
		tempColor = colorTable[Random.Range(0, colorTable.Length)];
		tempObstacle.GetComponent<Obstacle>().SetObstacle(tempColor, obstacleId, obstacleId * deltaObstacle);
		camObject.transform.position = new Vector3(0f, 0f, -10f);
		player.transform.position = nextObstacle.transform.position;
		readyToShoot = true;
	}

	private IEnumerator ShotBall()
	{
		player.GetComponent<Player>().ShotBullet();
		yield return new WaitForSeconds(0.4f);
		shooting = false;
	}

	public void MovePlayer()
	{
		readyToShoot = false;
		movingPlayer = true;
		CreateNextObstacle();
		camObject.GetComponent<CameraFollowTarget>().EnableDisableFollow(status: true);
	}

	private void CreateNextObstacle()
	{
		obstacleId++;
		tempColor = colorTable[Random.Range(0, colorTable.Length)];
		float num = UnityEngine.Random.Range(yMinDistanceBetweenObstacles, yMaxDistanceBetweenObstacles);
		nextObstacle = UnityEngine.Object.Instantiate(obstaclePrefab);
		nextObstacle.transform.position = new Vector2(tempObstacle.transform.position.x + UnityEngine.Random.Range(0f - maxXDistanceNextObstacle, maxXDistanceNextObstacle), tempObstacle.transform.position.y + num);
		nextObstacle.GetComponent<Obstacle>().SetObstacle(tempColor, obstacleId, obstacleId * deltaObstacle);
		tempObstacle.GetComponent<Obstacle>().SetNextObstaclePosition(nextObstacle.transform.position);
		player.GetComponent<Player>().targetPos = nextObstacle.transform.position;
		tempObstacle = nextObstacle;
	}

	public void PlayerDeath()
	{
		camObject.GetComponent<CameraFollowTarget>().ShakeCamera();
		player.GetComponent<Player>().PlayGameOver();
	}

	public void ResetPlayerAnimation()
	{
		player.GetComponent<Player>().ResetPlayer();
	}

	public void RestartGame()
	{
		if (uIManager.gameState == GameState1.PAUSED)
		{
			Time.timeScale = 1f;
		}
		ClearScene();
		CreateScene();
		readyToShoot = false;
		movingPlayer = false;
		scoreManager.ResetCurrentScore();
		uIManager.ShowGameplay();
		camObject.GetComponent<CameraFollowTarget>().EnableDisableFollow(status: false);
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
	public void ClearScene()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Obstacle");
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.Destroy(array[i]);
		}
	}

	public void GameOver()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
}
