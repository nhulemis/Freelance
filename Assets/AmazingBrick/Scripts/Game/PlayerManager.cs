
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
	
        public class HMDHOJYYZAOYXRVUYNMPRWAKKN
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class BHBLFRLHWKRLKHKDMFRXSOUBICQRQ
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class OOERZVLWYGZMNZJZOOBPALZGUQGHBPBAA
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class GVLUDIOLNJCZFLIWMJILAMHNLHTJO
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class SBOHDUEBRHWROKEOA
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF
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

        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF()
        {
            
        }
        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF GetFJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(){
        var clasx = new FJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF();
        return  clasx;
    }

    public string RandomStringFJALHUJOTCWIEXZBEHRMWAAHKYGHIHPWBMHPYVJASMYXFWTDPF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU
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

        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU()
        {
            
        }
        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU GetIZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(){
        var clasx = new IZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU();
        return  clasx;
    }

    public string RandomStringIZPTVTGADKGSHWZZPVLPISYSDPAOMHXSU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF
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

        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF()
        {
            
        }
        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF GetTUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(){
        var clasx = new TUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF();
        return  clasx;
    }

    public string RandomStringTUMBJEXVQHUMKDSNDOYIBALHOXYNJGLGOHXCEF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF
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

        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF()
        {
            
        }
        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF GetEAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(){
        var clasx = new EAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF();
        return  clasx;
    }

    public string RandomStringEAMKDDLTRWLBRQYOQYFCONEXBNSIXTEZUQEWBPNTSTFNDF(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI
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

        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI()
        {
            
        }
        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI GetMSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(){
        var clasx = new MSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI();
        return  clasx;
    }

    public string RandomStringMSUEWCKMYABAAWEUZNKGLZUJIXVTGHEEHELKLSVJABI(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf
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

        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf()
        {
            
        }
        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf GetSiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(){
        var clasx = new SiVJUgxMSTCpzCNpQgyFpfFEMqnpbf();
        return  clasx;
    }

    public string RandomStringSiVJUgxMSTCpzCNpQgyFpfFEMqnpbf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk
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

        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk()
        {
            
        }
        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk GetgoMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(){
        var clasx = new goMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk();
        return  clasx;
    }

    public string RandomStringgoMknmXoAIzAQGOuDcPxZNNBcCaJKxOtAxnssNOpdhPBNmUxdk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class EizkmfhTzQOiEEgVjEIojKPubojHDah
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

        public EizkmfhTzQOiEEgVjEIojKPubojHDah()
        {
            
        }
        public EizkmfhTzQOiEEgVjEIojKPubojHDah(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public EizkmfhTzQOiEEgVjEIojKPubojHDah(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public EizkmfhTzQOiEEgVjEIojKPubojHDah GetEizkmfhTzQOiEEgVjEIojKPubojHDah(){
        var clasx = new EizkmfhTzQOiEEgVjEIojKPubojHDah();
        return  clasx;
    }

    public string RandomStringEizkmfhTzQOiEEgVjEIojKPubojHDah(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz
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

        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz()
        {
            
        }
        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz GetkIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(){
        var clasx = new kIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz();
        return  clasx;
    }

    public string RandomStringkIrdOrlSsaysGOwPQHAVCfergYclkCzzxITCRbGpdILXjwYrLIGecczFezwqPz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx
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

        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx()
        {
            
        }
        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx GetmNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(){
        var clasx = new mNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx();
        return  clasx;
    }

    public string RandomStringmNKeffDtMYkYrNoeVgmDtJPruuIFUvrhcOalxHEvymSyQPxAwObDJtEcx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ
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

        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ()
        {
            
        }
        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ GetAEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(){
        var clasx = new AEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ();
        return  clasx;
    }

    public string RandomStringAEKginenRrdSuSaeVkIDzByTadxHjmyrZeCegDjsSCfRSEAIOFZtLcnzGrFEpXEfsmtQ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR
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

        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR()
        {
            
        }
        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR GetGrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(){
        var clasx = new GrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR();
        return  clasx;
    }

    public string RandomStringGrfgODsngghwjucemzzSKCJyBrGNfOnkZCaIARtqibndSdbyR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa
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

        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa()
        {
            
        }
        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa GetMQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(){
        var clasx = new MQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa();
        return  clasx;
    }

    public string RandomStringMQRMYEIyAiZMVuBUJoYCqFdNCmjcgQtaa(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class IKPoLnSWflsxFxHlFBIxQndzcKdeNz
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

        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz()
        {
            
        }
        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public IKPoLnSWflsxFxHlFBIxQndzcKdeNz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public IKPoLnSWflsxFxHlFBIxQndzcKdeNz GetIKPoLnSWflsxFxHlFBIxQndzcKdeNz(){
        var clasx = new IKPoLnSWflsxFxHlFBIxQndzcKdeNz();
        return  clasx;
    }

    public string RandomStringIKPoLnSWflsxFxHlFBIxQndzcKdeNz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD
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

        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD()
        {
            
        }
        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD GetQDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(){
        var clasx = new QDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD();
        return  clasx;
    }

    public string RandomStringQDIWKnQsQBmwXrsNjrOfUAIefZfjrzsnkTsWNZMeqZoCkOpcRfPPKD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ
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

        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ()
        {
            
        }
        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ GetlyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(){
        var clasx = new lyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ();
        return  clasx;
    }

    public string RandomStringlyauStJHkJfhjPTPJvQWujGLtcQSBnCKsLYOVenzBVNJsusLVxwLmJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV
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

        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV()
        {
            
        }
        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV GetyTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(){
        var clasx = new yTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV();
        return  clasx;
    }

    public string RandomStringyTozfVrsHGzmEBuzbJmMQUfeoNvBKNMcnTAtFOVZiFV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww
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

        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww()
        {
            
        }
        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww GetdhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(){
        var clasx = new dhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww();
        return  clasx;
    }

    public string RandomStringdhzNwJPkcypaUdvLFSXwDPjQxptWbqTGVYhaNPDQnAzJuWOHvnCUxlHNyjPHPsJlfjEww(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja
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

        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja()
        {
            
        }
        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja GetuhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(){
        var clasx = new uhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja();
        return  clasx;
    }

    public string RandomStringuhMwNYWsgnyRpvsquWrLURYalzGJpzUlbyxja(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD
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

        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD()
        {
            
        }
        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD GetJeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(){
        var clasx = new JeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD();
        return  clasx;
    }

    public string RandomStringJeUJKiAiJlPqpVZzHdeBANcHFYmKeFyHEjrFwRDcBTSMnPStckuUtuhvBMD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO
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

        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO()
        {
            
        }
        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO GetAdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(){
        var clasx = new AdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO();
        return  clasx;
    }

    public string RandomStringAdlojIQvZBscLawmLMxVNljmzHyZUiwJMzbxzvUfkgoRZUCLVtisFUCO(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW
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

        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW()
        {
            
        }
        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW GetufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(){
        var clasx = new ufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW();
        return  clasx;
    }

    public string RandomStringufPSjtcSGfjWAXjUDagWnDLYjGSVTvORgOYsprlOELqekzOjKGW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC
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

        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC()
        {
            
        }
        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC GetGDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(){
        var clasx = new GDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC();
        return  clasx;
    }

    public string RandomStringGDpaXwaRTNgrPTGVCaTiEfYNsgJDGIcpMMmSUcvAnPaxYvpHlgjUqJnbfbhqnWLLkqfC(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RbfCrpgSXZFIDxcdOziZKZflJMLZlt
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

        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt()
        {
            
        }
        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RbfCrpgSXZFIDxcdOziZKZflJMLZlt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RbfCrpgSXZFIDxcdOziZKZflJMLZlt GetRbfCrpgSXZFIDxcdOziZKZflJMLZlt(){
        var clasx = new RbfCrpgSXZFIDxcdOziZKZflJMLZlt();
        return  clasx;
    }

    public string RandomStringRbfCrpgSXZFIDxcdOziZKZflJMLZlt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class MrlsshplrnNCcUSHoswgmjWIpBIfcTL
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

        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL()
        {
            
        }
        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public MrlsshplrnNCcUSHoswgmjWIpBIfcTL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public MrlsshplrnNCcUSHoswgmjWIpBIfcTL GetMrlsshplrnNCcUSHoswgmjWIpBIfcTL(){
        var clasx = new MrlsshplrnNCcUSHoswgmjWIpBIfcTL();
        return  clasx;
    }

    public string RandomStringMrlsshplrnNCcUSHoswgmjWIpBIfcTL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu
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

        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu()
        {
            
        }
        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu GetPSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(){
        var clasx = new PSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu();
        return  clasx;
    }

    public string RandomStringPSRjOQIfSBwcmQRbTjOMJLVnOOgxWwNrOTOXddOTqfnDFGu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV
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

        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV()
        {
            
        }
        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV GetrerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(){
        var clasx = new rerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV();
        return  clasx;
    }

    public string RandomStringrerVloPuBxEEIEBOicAOiWbYAUiByDANtGUpHDHeTXposWVXMIqxcOiVCSV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class VClhHrvIDrLroovZlUCkXxhrlXjptq
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

        public VClhHrvIDrLroovZlUCkXxhrlXjptq()
        {
            
        }
        public VClhHrvIDrLroovZlUCkXxhrlXjptq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VClhHrvIDrLroovZlUCkXxhrlXjptq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VClhHrvIDrLroovZlUCkXxhrlXjptq GetVClhHrvIDrLroovZlUCkXxhrlXjptq(){
        var clasx = new VClhHrvIDrLroovZlUCkXxhrlXjptq();
        return  clasx;
    }

    public string RandomStringVClhHrvIDrLroovZlUCkXxhrlXjptq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD
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

        public lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD()
        {
            
        }
        public lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD GetlIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD(){
        var clasx = new lIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD();
        return  clasx;
    }

    public string RandomStringlIHENdaufjHRFQzAvuSdwWnDnUXFfmCMD(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU
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

        public PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU()
        {
            
        }
        public PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU GetPqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU(){
        var clasx = new PqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU();
        return  clasx;
    }

    public string RandomStringPqvzBgkCnSnAEWmmUCHlgfscqeuEEcfEVtpU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi
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

        public HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi()
        {
            
        }
        public HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi GetHjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi(){
        var clasx = new HjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi();
        return  clasx;
    }

    public string RandomStringHjaGCoTFsqOGTIQvcRpELYHPkAyVyJDgXmKTkRErfJDFkIrNXQUzSwFjbLWCqyHimi(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV
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

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV()
        {
            
        }
        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV GetetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(){
        var clasx = new etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV();
        return  clasx;
    }

    public string RandomStringetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz
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

        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz()
        {
            
        }
        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz GetjymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(){
        var clasx = new jymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz();
        return  clasx;
    }

    public string RandomStringjymmUppAaRjxRAPBllSkMnsSSypaxpgRPAvXqeSDRcjLOsrbRASRyeTvGTTWz(int length)
    {
        string chars = string.Empty;
        return chars;
    }
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