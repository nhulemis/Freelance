//using MEC;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using RoadCreator;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
//using GameAnalyticsSDK;

public class Gameplay : MonoBehaviour
{
	public enum GameState
	{
		Init,
		Play,
		Lose,
		Win,
		Pause,
		Resume,
		Revive
	}

	[SerializeField] Camera mainCamera;
	public Camera Camera => mainCamera;
	//	[SerializeField] Character character;
	//	public Character Character => character;
	private PlayerController character;
	[SerializeField] Level level;
	public Level Level => level;
	[SerializeField] CameraController cameraController;
	//[SerializeField] GameObject flyElementGroup;
	//public GameObject FlyElementGroup => FlyElementGroup;
	//[SerializeField] FinishStage finishStage;
	//public FinishStage FinishStage => finishStage;
	//[SerializeField] RectTransform progressArrow;
	//[SerializeField] Text levelProgressText;
	//[SerializeField] CanvasGroup keyGroup;
	[SerializeField] int levelCount;
	[SerializeField] ElementAnalysis elementAnalysis;

	public bool Finished { get; private set; } = false;
	public int EarnedGem { get; set; } = 0;

	//StateManager stateManager = new StateManager();
	public static Gameplay Instance;
	//public bool IsPlaying => stateManager.CurrentStateKey.Equals(GameState.Play);
	public float RoadWidth => level.Width;
	public float Speed { get; set; } = 10;

	private void Awake()
	{
		Instance = this;
		character = GameObject.FindObjectOfType<PlayerController>();

	//	Analytics.Instance.Init();
	//	Ads.Instance.Init();
	}

	private void OnDestroy()
	{
		Instance = null;
	}

	private void Start()
	{
		
		ChangeState(GameState.Init);
		Init();
	}

	public void ChangeState(GameState state)
	{
		//stateManager.ChangeState(state);
	}

	public void Init()
	{

		RenderSettings.fogStartDistance = GameConstanst.FogStartDistanceFar;
		RenderSettings.fogEndDistance = GameConstanst.FogEndDistanceFar;
		cameraController.ChaseEnable = true;
		//Character.SnakeEnable = true;
		Finished = true;
		if(level != null)
		{
			level = Instantiate(level);
		}
		
		else
		{
			level = elementAnalysis.GenerateLevel(Random.Range(0.6f, 1f));
		}
		
		level.transform.SetParent(transform);
		level.Init();
		//character.Init(level.SnakeLength);
		character.MoveTo(level.CurrentPart.GetPointAtTime(GameConstanst.StartPosition / level.CurrentPart.Length));
		//cameraController.ChaseImmediate(character.transform);
		Speed = level.CurrentPart.Speed;
		//BonusCoinElement.XCount = 1;
		EarnedGem = 0;
		//levelProgressText.text = Profile.Instance.Level.ToString();
		//progressArrow.transform.parent.gameObject.SetActive(false);
		//FinishStage.gameObject.SetActive(false);
		//SceneMaster.Instance.OpenScene(SceneID.Home);
	}

	public void Play()
	{
		//character.SwitchAnimation(Baby.BabyTrigger.Running);
		//progressArrow.transform.parent.gameObject.SetActive(true);
		ChangeState(GameState.Play);
		//GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "World", $"Level_{Profile.Instance.Level}",
//"Level_Progress");
	}

	public void Lose()
    {
		ChangeState(GameState.Lose);
    }

	public void Win()
	{
		//progressArrow.transform.parent.gameObject.SetActive(false);
		ChangeState(GameState.Win);
	}

   
    public void DoFrame()
	{
		if(!Finished)
		{
			level.DoFrame();
		}
		
		character.DoFrame();

	    if (!character.HitObstacle)
		{
			cameraController.Chase(character.FollowCam);
		}

	}
	
	public void Land()
	{

		if(Finished)
		{
			return;
		}
		
		Finished = true;
	  
	}
	
	public void SpeedUp()
	{
		var targetSpeed = level.CurrentPart.Speed * 1.7f;
		StartCoroutine(IEChangeSpeed(targetSpeed, 5));
		//SoundManager.Instance.PlaySFX("DM-CGS-15", 1);
	}

	Coroutine speedDownCoroutine;
	public void SpeedDown()
	{
		var targetSpeed = level.CurrentPart.Speed * 0.8f;
		if(Speed <= targetSpeed)
		{
			return;
		}

		if(speedDownCoroutine != null)
			StopCoroutine(speedDownCoroutine);
		speedDownCoroutine = StartCoroutine(IEChangeSpeed(targetSpeed, 1f));
	}

	IEnumerator IEChangeSpeed(float target, float totalTime)
	{
		Speed = target;
		yield return new WaitForSeconds(totalTime);
		Speed = level.CurrentPart.Speed;
	}

	public void ShowKeyAmount()
	{
		/*keyGroup.alpha = 0;
		keyGroup.DOFade(1, 0.3f);
		for (int i = 1; i < 4; i++)
		{
			var key = keyGroup.transform.GetChild(i);
		
		}
		keyGroup.DOFade(0, 0.3f).SetDelay(3.5f);*/
	}

	private void Update()
	{
		DoFrame();
		//stateManager.UpdateExecute();
	} 
	public void finish()
    {
		Finished = true;
		
    }
	public void startPlay()
    {
		Finished = false;

	}
}
