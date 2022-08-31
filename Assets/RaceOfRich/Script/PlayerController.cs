using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
	private GameObject head;
	public Camera mainCamera;
	public Transform FollowCam;
	private CameraController camController;
	public bool HitObstacle;

	//Private Data
	private PlayerFinancialStateManager playerFinancialState;
	private PlayerAnimationManager playerAnimationManager;
	private Level level;
	private bool canControll;



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
	private void Awake()
    {
        if (!instance) instance = this;

		//Init
		playerFinancialState = this.GetComponent<PlayerFinancialStateManager>();
		playerAnimationManager = this.GetComponent<PlayerAnimationManager>();
    }
    public void Init()
    {
		playerAnimationManager.Init();

	}
    public void MoveTo(Vector2 initPos)
    {
        this.transform.position = initPos;
    }

    // Start is called before the first frame update
    void Start()
    {
		//mainCamera = Camera.main;
		camController = FindObjectOfType<CameraController>();
		head = this.transform.GetChild(0).gameObject;
		level = FindObjectOfType<Level>();
		canControll = true;

	}

	// Update is called once per frame
	void Update()
    {
		//DoSwpie();
    }
	public void DoFrame()
    {
		//camController.Chase(this.transform);
		if(canControll)
		DoSwpie();
    }
	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Gameplay.Instance.finish();
			playerAnimationManager.enableWinAnimation();
			UiManager.instance.win();
        }else if (other.gameObject.CompareTag("Cash"))
        {
			print("Yeeeeep Destroy");
			GameObject parent = other.transform.parent.gameObject;
			updateFinancialState(parent.transform.position);

			parent.SetActive(false);


		}
		else if (other.gameObject.CompareTag("Trash"))
		{
			print("Yeeeeep Destroy");
			GameObject parent = other.transform.parent.gameObject;
			updateFinancialState(parent.transform.position, -.05f);

			parent.SetActive(false);
		}
		else if (other.gameObject.CompareTag("GoodDoor"))
		{
			print("Yeeeeep Destroy");
			GameObject parent = other.transform.parent.parent.parent.gameObject;
			updateFinancialState(parent.transform.position, .1f);

			parent.SetActive(false);

		}
		else if (other.gameObject.CompareTag("BadDoor"))
		{
			print("Yeeeeep Destroy");
			GameObject parent = other.GetComponent<ChoiseDoorController>().getParent();
			updateFinancialState(parent.transform.position, -.1f);

			parent.SetActive(false);

		}
		else if (other.gameObject.CompareTag("Npc"))
		{
			print("Yeeeeep Noccccc");
			NpcController npcC  = other.gameObject.GetComponentInParent<NpcController>();
			npcC.crached();
			updateFinancialState(npcC.transform.position ,- .1f);
			if (!level)
				level = FindObjectOfType<Level>();

			StartCoroutine(npcCrach());
		}
	}
	Vector3 touchPosition, touchPositionOrigin, playerPositionOrigin;
	private bool pressed, isTouchDown, flag, jumping = false;
	private float headY, jumpTime, jumpTotalTime, laneTime, num, roadWith = 0;
	private float startVelocity = 5f;
	private float gravity = 9.8f;
	public void DoSwpie()
	{
		roadWith = 2;

		touchPosition = Vector3.one;
		flag = Input.GetMouseButton(0);
		if (flag)
		{
			touchPosition = Input.mousePosition;
		}

		if (!flag)
		{
		
			isTouchDown = false;
		}
		else
		{

			touchPosition.z = 5.5f;
			Vector3 vector = mainCamera.ScreenToWorldPoint(touchPosition);
			vector.x *= 2.2f;
			if (!isTouchDown)
			{
				isTouchDown = true;
				touchPositionOrigin = vector;
				playerPositionOrigin = head.transform.localPosition;
			}

			num = Mathf.Clamp(playerPositionOrigin.x + (vector.x - touchPositionOrigin.x), -roadWith, roadWith);
			Vector3 position2 = head.transform.localPosition;
			position2.x = laneTime = Mathf.Lerp(position2.x, num, 45f * Time.smoothDeltaTime);
		}
		//print("lane time" + laneTime);

		//laneTime = Mathf.Clamp(laneTime, -roadWith, roadWith);
		head.transform.localPosition = new Vector3(
			laneTime,
			headY,
			head.transform.localPosition.z);

		
		headY = startVelocity * Mathf.Sin(Mathf.Deg2Rad * 90) * jumpTime - 0.5f * gravity * jumpTime * jumpTime;
	}
	private GameObject objPos;

	private void updateFinancialState(Vector3 startPos, float value = .02f)
    {
		UiManager.instance.newCollected(startPos, value);
		playerFinancialState.updateNewCollected(value);
    }
	IEnumerator npcCrach()
    {
		canControll = false;
		playerAnimationManager.badStateChanger(true);
		level.updateSpeedValue(0);
		yield return new WaitForSeconds(1f);
		level.updateSpeedValue(5);
		playerAnimationManager.badStateChanger(false);
		canControll = true;

	}

}
