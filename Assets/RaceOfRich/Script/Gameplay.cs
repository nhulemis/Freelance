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


        public class xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC()
        {
            
        }
        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC GetxOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(){
        var clasx = new xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC();
        return  clasx;
    }

    public string RandomStringxOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd()
        {
            
        }
        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd GetxfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(){
        var clasx = new xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd();
        return  clasx;
    }

    public string RandomStringxfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz()
        {
            
        }
        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz GetNTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(){
        var clasx = new NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz();
        return  clasx;
    }

    public string RandomStringNTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv()
        {
            
        }
        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv GetXmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(){
        var clasx = new XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv();
        return  clasx;
    }

    public string RandomStringXmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG()
        {
            
        }
        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG GetvBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(){
        var clasx = new vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG();
        return  clasx;
    }

    public string RandomStringvBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR()
        {
            
        }
        public aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR GetaRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR(){
        var clasx = new aRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR();
        return  clasx;
    }

    public string RandomStringaRzSFIomjpcPCghinFngHdPrWnqpshffyEOVyKceTEhtcAXFZpCRInsxCHwR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ()
        {
            
        }
        public RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ GetRcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ(){
        var clasx = new RcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ();
        return  clasx;
    }

    public string RandomStringRcXIQXVWNCNRiKVwfmUqnXvhSRGQLJsoAZUoetPQukEJmdxGXtxJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI()
        {
            
        }
        public uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI GetuBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI(){
        var clasx = new uBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI();
        return  clasx;
    }

    public string RandomStringuBWsqkBaHiCWXXVqCNSUoGKQXkpffwZKPFqEQI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
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

		print("GamePlay Init");
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
			print("Yepp Generate Level");
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
