using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

#if UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif

/// <summary>
/// Class in charge of the logic of the game. This class will restart the level at game over, handle and save the point, and call the Ads if you import the VERY SIMPLE ADS asset available here: http://u3d.as/oWD
/// </summary>
public class GameManager : MonoBehaviour
{

	public Color backgroundColor = Color.white;
	public Color circleColor = Color.black;
	public Color playerColor = Color.white;
	public Color hazardColor
	{
		get
		{
			return backgroundColor;
		}
	}

	public bool activateCameraShake = false;

	public int numberOfPlayToShowInterstitial = 5;

	[NonSerialized] public bool isStarted = false;

	[NonSerialized] public bool isGameOver = false;

	public Text pointText;

	CanvasScaler canvasScaler;

	public GameObject circlePrefab;

	public GameObject particle;

	public GameObject obstaclePrefab;

	private int point = 0;

	[NonSerialized] public float radiusBorder;

	Player player;

	SoundManager soundManager;

	void Awake()
	{
		player = FindObjectOfType<Player>();
		soundManager = FindObjectOfType<SoundManager>();

		if(Time.realtimeSinceStartup < 1)
			DOTween.Init();


		DOTween.KillAll();

		SetNewGame ();

		GC.Collect();
		Resources.UnloadUnusedAssets();
		Application.targetFrameRate = 60;


		Init();


		if(FindObjectOfType<SpawnManager>() == null)
		{
			GameObject go = new GameObject();

			go.name = "_SpawnManager";

			go.AddComponent(typeof(SpawnManager));

			go.GetComponent<SpawnManager>().particle = this.particle;

			go.GetComponent<SpawnManager>().Init();
		}
	}

	public void Start()
	{
		InstantiateCircle();
	}

	void Init()
	{
		Camera cam = Camera.main;
		float height = 2f * cam.orthographicSize;
		float width = height * cam.aspect;

		this.radiusBorder = width * 0.80f / 2f;

	}

	public void Add1Point()
	{
		if(DOTween.IsTweening(Camera.main))
			return;
		
		point++;
	
		pointText.text = point.ToString();

		soundManager.PlayTouch ();

		FindObjectOfType<Circle>().DOParticle();
	}

	public void InstantiateCircle()
	{
		var radius = this.radiusBorder;

		player.DOPosition(radius, 0);

		var go = Instantiate(circlePrefab) as GameObject;

		go.transform.position = new Vector3(0,0,98f);


		var circle = go.GetComponent<Circle>();

		circle.SetRadius(radius);
		circle.DOStart();
	}

	public void DOStart()
	{
		StartCoroutine(ObstacleInstantiator());
	}

	IEnumerator ObstacleInstantiator()
	{
		while(true)
		{
			var allObstacles = FindObjectsOfType<ObstacleLogic>();

			bool doInstantiateObstacle = false;

			if(allObstacles != null && allObstacles.Length > 1)
			{
				var allVisibleObtacles = Array.FindAll(allObstacles, o => o.isVisible == true);

				if(allVisibleObtacles != null && allVisibleObtacles.Length < point + 3)
				{
					doInstantiateObstacle = true;
				}
			}
			else
			{
				doInstantiateObstacle = true;
			}

			if(doInstantiateObstacle)
			{
				DOInstantiateObstacle();
			}

			yield return new WaitForSeconds(Util.GetRandomNumber(0.20f,0.5f));
		}
	}

	void DOInstantiateObstacle()
	{
		var o = Instantiate(obstaclePrefab) as GameObject;

		ObstacleLogic ob = o.GetComponent<ObstacleLogic>();

		ob.Init(player.GetRotation() - 30, Util.GetRandomNumber(0f,100f) < 50);
	}

	void SetNewGame()
	{
		point = 0;

		pointText.text = point.ToString ();

		player.transform.eulerAngles = Vector3.zero;
	}

	/// <summary>
	/// If using Very Simple Leaderboard by App Advisory, report the score : http://u3d.as/qxf
	/// </summary>
	void ReportScoreToLeaderboard(int p)
	{
		#if APPADVISORY_LEADERBOARD
		LeaderboardManager.ReportScore(p);
		#else
		if(PlayerPrefs.GetInt("VERY_SIMPLE_LEADERBOARD_COUNT", 0) > 32)
		{
			print("Get very simple leaderboard to use it : http://u3d.as/qxf");
			PlayerPrefs.SetInt("VERY_SIMPLE_LEADERBOARD_COUNT", 0); 
			PlayerPrefs.Save();
		}
		else
		{
			PlayerPrefs.SetInt("VERY_SIMPLE_LEADERBOARD_COUNT", PlayerPrefs.GetInt("VERY_SIMPLE_LEADERBOARD_COUNT", 0) + 1);
			PlayerPrefs.Save();
		}

		#endif
	}


  public void ShowAds()
  {

  }




  public void GameOver()
  {
    
    
	    if(isGameOver)
		    return;

	    ReportScoreToLeaderboard(point);

	    isGameOver = true;

	    player.DesactivateTouchControl();

	    DOTween.KillAll();

	    Util.SetLastScore(point);

	    ShowAds();

	    StopAllCoroutines ();

	    DOTween.KillAll();

	    soundManager.PlayFail ();

	    FindObjectOfType<CanvasManager>().OnGameOver(() => {

		    DOTween.KillAll();

		    #if UNITY_5_3_OR_NEWER
		   var load = SceneManager.LoadSceneAsync (0, LoadSceneMode.Single);
		    #else
		    Application.LoadLevel(Application.loadedLevel);
		    #endif
        
        GameItemManager.Instance.UseCoin(1);
	    });
    }
  public class KJHXHKaklkhjwuaj
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;
  }
  public class JKZioaw
  {
    public int A;
    public int B;
    public string C;
    public bool X;
    private double D;
    private float E;

    public void ALKJXCL()
    {
      
    }
  }
}