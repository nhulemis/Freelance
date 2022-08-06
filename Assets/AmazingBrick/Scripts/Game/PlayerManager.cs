
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using System.Collections;

#if AADOTWEEN
using DG.Tweening;
#endif

#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class who managed the player
	/// 
	/// This script is attached go the GameObject "Player".
	/// In charge to detect the input, and to jump the player from one side to the other side, and detect collisions. 
	/// You can change the speed of the jump in this GameObject ("Constant force y") and the speed of the player ("Constant force x").
	/// </summary>
	public class PlayerManager : MonoBehaviorHelper
	{

    public class ProductItem
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class CKjioaw
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class KLCJiajwl
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }

    
    public class Kciwlzxc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    
    public class CHuaiwsczx
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    
    public class Ciouawlkjix
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class Caixaw3f
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class Cjiaw
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
    public class Cjlkajwiolxkc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;
      
      public string LKJClkwio { get; set; }
    }
        public ParticleSystem ParticleSystemExplosionNewPoint;

		public bool ONE_TOUCH_CONTROL = false;

		bool lastWasLeft = false;

		/// <summary>
		/// True if the player can jump
		/// </summary>
		private bool canJump;

		/// <summary>
		/// True if game over
		/// </summary>
		private bool isGameOver;


		/// <summary>
		/// The force apply to the player when is jumping
		/// </summary>
		public float ConstantForceX;

		/// <summary>
		/// The force apply to the player to move up continuously
		/// </summary>
		public float ConstantForceY;

		/// <summary>
		/// reference to the player rigidbody2D
		/// </summary>
		private Rigidbody2D _rigidbody;

		bool _isInvicible;
		public bool isInvicible
		{
			set
			{
				_isInvicible = value;

				if(value == true)
				{

				}
				else
				{

				}
			}
			get
			{
				return _isInvicible;
			}
		}




		//	public delegate void StartContinuePopup ();
		//	public static event StartContinuePopup OnStartContinuePopup;
		//
		//	public delegate void ContinueSuccess ();
		//	public static event ContinueSuccess OnContinueSuccess;



		void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D> ();
			_rigidbody.isKinematic = true;
			transform.position = Vector2.zero;
			canJump = false;
		}

		/// <summary>
		/// Subscribe to OnTouchScreen from InputTouch
		/// </summary>
		void OnEnable()
		{
			InputTouch.OnTouchScreen += OnTouchScreen;

			EventManager.OnGameStarted += OnStarted;

			EventManager.OnGameEnded += OnFinished;

			EventManager.OnClickedGameOverButtons += OnClickedGameOverButtons;
		}

		/// <summary>
		/// Unsubscribe to OnTouchScreen from InputTouch
		/// </summary>
		void OnDisable()
		{
			InputTouch.OnTouchScreen -= OnTouchScreen;

			EventManager.OnGameStarted -= OnStarted;

			EventManager.OnGameEnded -= OnFinished;

			EventManager.OnClickedGameOverButtons -= OnClickedGameOverButtons;
		}

		void OnTouchScreen(DIRECTION dir)
		{
			if(ONE_TOUCH_CONTROL)
			{
				if(lastWasLeft)
				{
					Jump(false);
				}
				else
				{
					Jump(true);
				}

				lastWasLeft = !lastWasLeft;
			}
			else
			{
				Jump(dir == DIRECTION.left);
			}
		}

		void Start()
		{
			isGameOver = false;
		}


		/// <summary>
		/// When game over, ridbody2d is kinematic so the player doesn't move anymore
		/// </summary>
		void OnFinished()
		{
			_rigidbody.isKinematic = true;
		}

		/// <summary>
		/// When the game is started, the ridbody2d is not kinematic (to apply force to it) and we start the coroutine to continuously move up the player
		/// </summary>
		private void OnStarted()
		{
			if (_rigidbody.isKinematic) {
				_rigidbody.isKinematic = false;
			}

			StartCoroutine (OnStartDelay ());
		}

		/// <summary>
		/// A little delay to start the game, just to have the tiome to emit the ParticleSystems and make some stuff like isGameOver = false and canJump = true with a delay
		/// </summary>
		IEnumerator OnStartDelay()
		{
			yield return new WaitForSeconds (0.3f);
			gameObject.SetActive (true);
			isGameOver = false;
			canJump = true;

		}

		/// <summary>
		/// Call OnCollision if collision with player and obstacles or walls 
		/// </summary>
		void OnCollisionEnter2D(Collision2D coll) 
		{
			//		EventManager.DOPlayerHit();

			if(isInvicible)
				return;

			OnCollision (coll.gameObject, coll);

		}

		/// <summary>
		/// Check who is collide with the player: if walls: emit ParticleSystems, if obstacles: game over
		/// </summary>
		void OnCollision(GameObject obj, Collision2D coll)
		{
			if (isGameOver)
				return;

			_rigidbody.velocity = new Vector2 (0, ConstantForceY);

			bool isCollisionGameOver = coll.gameObject.name.Contains("Wall") 
				|| coll.gameObject.name.Contains("Wall")
				|| coll.gameObject.name.Contains("Rectangle") 
				|| coll.gameObject.name.Contains("Square");


			if (isCollisionGameOver) 
				LaunchGameOver ();

		}

		/// <summary>
		/// Turn isGameOver to true and lauch the coroutine CoroutLaunchGameOver
		/// </summary>
		void LaunchGameOver()
		{
			if (isGameOver)
				return;

			isGameOver = true;


			EventManager.DOPlayerFail();

			_rigidbody.velocity = Vector2.zero;

			_rigidbody.isKinematic = true;

			GetComponent<Collider2D> ().enabled = false;


			StartCoroutine(CameraShake.Shake(camTransform,0.05f));
		}

		void OnClickedGameOverButtons(bool success)
		{
			if (success) 
			{
				gameManager.gameObject.SendMessage("DespawnNearestObstacle");

				_rigidbody.velocity = Vector2.zero;

				_rigidbody.isKinematic = false;

				isGameOver = false;

				canJump = true;

				GetComponent<Collider2D> ().enabled = true;

				int direction = (transform.position.x >= 0) ? 1 : -1;

				var pos = transform.position;
				pos.x = 0;
				pos.y = camTransform.position.y;
				transform.position = pos;


				_rigidbody.velocity = new Vector2 (direction*ConstantForceX , ConstantForceY);

			} 
			else 
			{
				gameManager.GameOver ();
			}
		}


		/// <summary>
		/// Do a player jump, ie. a move on the X axis
		/// </summary>
		void Jump(bool isLeft)
		{
			if (!canJump || isGameOver)
				return;

			int direction = isLeft ? -1 : 1;

			EventManager.DOPlayerJump();

			_rigidbody.velocity = Vector2.zero;


			_rigidbody.velocity = new Vector2 (direction*ConstantForceX , ConstantForceY);

			#if UNITY_5_3
			_rigidbody.freezeRotation = true;
			_rigidbody.freezeRotation = false;
			#endif

			_rigidbody.angularVelocity = -680*direction; //680

			if(ParticleSystemExplosionNewPoint.gameObject.activeInHierarchy)
				ParticleSystemExplosionNewPoint.Emit(1);



		}
	}
}