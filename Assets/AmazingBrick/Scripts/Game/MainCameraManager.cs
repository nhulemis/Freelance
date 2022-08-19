
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using System;
using System.Collections;

#if AADOTWEEN
using DG.Tweening;
#endif

using AppAdvisory;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to follow the player and to place the left and right walls on the screen
	/// 
	/// This script is attached to the Main Camera. This script is in charge to follow the Player vertically.
	/// </summary>
	public class MainCameraManager : MonoBehaviorHelper
	{
		/// <summary>
		/// Reference to the left wall
		/// </summary>
		public Transform left;
		/// <summary>
		/// Reference to the right wall
		/// </summary>
		public Transform right;

		/// <summary>
		/// If useContantWidth = true, the space between the left and right walls
		/// </summary>
		public float constantWidth = 15f;

		Vector3 posPlayer
		{
			get
			{
				var p = playerTransform.position;

				p += Vector3.up * 5f;

				return p;
			}
		}

		Vector3 myPos
		{
			set
			{
				transform.position = new Vector3(value.x, value.y, transform.position.z);
			}
		}


		[NonSerialized] Camera camMain;
		[NonSerialized] Camera camBack1;
		[NonSerialized] Camera camBack2;
		[NonSerialized] Camera camFor;

		public float GetHeight(CameraType type)
		{
			if(GetCamera(type) == null)
				return -1;

			return GetCamera(type).GetHeight();
		}

		public float GetWidth(CameraType type)
		{
			if(GetCamera(type) == null)
				return -1;

			return GetCamera(type).GetWidth();
		}

		public Camera GetCamera(CameraType type)
		{
			Camera camTemp = null;

			if(type == CameraType.main)
			{
				camTemp = camMain;
			}
			else if(type == CameraType.background1)
			{
				camTemp = camBack1;
			}
			else if(type == CameraType.background2)
			{
				camTemp = camBack2;
			}
			else if(type == CameraType.foreground)
			{
				camTemp = camFor;
			}

			return camTemp;
		}

		public Camera GetCamera(BackgroundLayer type)
		{
			Camera camTemp = null;

			if(type == BackgroundLayer.Background1Layer)
			{
				camTemp = camBack1;
			}
			else if(type == BackgroundLayer.Background2Layer)
			{
				camTemp = camBack2;
			}
			else if(type == BackgroundLayer.ForegroundLayer)
			{
				camTemp = camFor;
			}
			else
			{
				return mainCamera;
			}

			return camTemp;
		}

		void Awake ()
		{
			camMain = Camera.main;
			camBack1 = transform.Find("CameraBackground1").GetComponent<Camera>();
			camBack2 = transform.Find("CameraBackground2").GetComponent<Camera>();
			camFor = transform.Find("CameraForeground").GetComponent<Camera>();

			var allCams = FindObjectsOfType<Camera>();



			foreach(var cam in allCams)
			{
				if(cam.name.Contains("Background1"))
				{
					camBack1 = cam;
				}
				else if(cam.name.Contains("Background2"))
				{
					camBack2 = cam;
				}
				else if(cam.name.Contains("Foreground"))
				{
					camFor = cam;
				}
			}


			float size = constantWidth;


			left.localPosition = new Vector2 (-size * 0.8f, 0);   

			right.localPosition = new Vector2 (+size * 0.8f , 0);   

			camMain.orthographicSize = constantWidth * 1.5f;

			camBack1.orthographicSize = camMain.orthographicSize * 2f;
			camBack2.orthographicSize = camBack1.orthographicSize * 2f;
			camFor.orthographicSize = camMain.orthographicSize / 2f;

			myPos = playerTransform.position;//posPlayer;
		}

		void OnEnable()
		{
			EventManager.OnGameStarted += OnStarted;

			EventManager.OnGameEnded += OnFinished;
		}
		void OnDisable()
		{
			EventManager.OnGameStarted -= OnStarted;

			EventManager.OnGameEnded -= OnFinished;
		}


	
        public class TLRGEPYCTYVNJKE
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

        public class CEKZBYNHFTIPCQ
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

        public class KQVNTALVWOBHLFECJGBUSMGOCAOWYDVKHZ
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
	private void OnStarted()
		{
			StartCoroutine(CoUpdate());
		}

		private void OnFinished()
		{
			StopAllCoroutines();
		}

		IEnumerator CoUpdate()
		{
			while(true)
			{
				UpdatePos();
				yield return 0;
			}
		}


		/// <summary>
		/// To update the Y position of the camera, y position always  player Y position (if the game is not at Game Over state)
		/// </summary>
	
        public class FXULOZLHTIDIZLMT
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
	public void UpdatePos()
		{

			if (playerTransform == null)
				return;

			Vector3 pos = transform.position;

			if(posPlayer.y > pos.y)
			{
				pos.y = Mathf.Lerp(pos.y, posPlayer.y, 0.07f * Time.time);
				transform.position = pos;
			}


		}


		public void DOGaussiamBlur(float _from, float _to)
		{

			//		gaussianFilter.enabled = true;
			//		gaussianFilter.nIterations = _from;
			//		gaussianFilter.lod = _from / 3f;
			//
			//		DOVirtual.Float(_from,_to,0.3f,(float f) => {
			//			gaussianFilter.nIterations = (f);
			//			gaussianFilter.lod = (f/3f);
			//		}).OnComplete(()=>{
			//			gaussianFilter.nIterations = _to;
			//			gaussianFilter.lod = _to / 3f;
			//
			//			if(_to == 0)
			//				gaussianFilter.enabled = false;
			//		});
		}
	}
}