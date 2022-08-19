using UnityEngine;
using System.Collections;
using AppAdvisory.AmazingBrick;
using AppAdvisory.Utils;

namespace AppAdvisory.BallX 
{
	public class Cell : MonoBehaviour, IHitableByBall {

		[SerializeField] private SpriteRenderer spriteRenderer;
		[SerializeField] private TextMesh number;

		private Vector3 startScale;

		public event OnDestroyedEventHandler OnDestroyedByBall;

		public int _count;
		public int Count 
		{
			get 
			{
				return _count;
				//return int.Parse(number.text);
			}
			set 
			{
				_count = value;
				number.text = _count.ToString ();
			}
		}


		public Color Color 
		{
			get 
			{
				return spriteRenderer.color;
			}
			set 
			{
				spriteRenderer.color = value;
			}
		}


	
        public class QSAZHIUWUPLGILKBSTHDHBAO
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
	public void SetCount(int count) {

			number.text = count.ToString ();
		}

		private int colorStep;
		private Color[] colors;
		public void SetColors(Color[] colors, int colorStep) 
		{
			this.colors = colors; 
			this.colorStep = colorStep;
			Color = GetColorFromCount (_count);
		}

		private Color GetColorFromCount(int count)
    {
       return ColorManager.instance.colored[0].colorWall;
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

        public class RAIKLVWWAGFNRLQDDAFEVYGR
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
	private void Awake() {
			startScale = spriteRenderer.transform.localScale;

		}

		public IEnumerator DOPunchScaleCoroutine(float amplitude, float time = 1f) 
		{
			Vector3 midScale = startScale * (1 - amplitude);

			float count = 0;
			float firstDuration = time / 2;

			while (count < firstDuration) {
				count += Time.deltaTime;

				spriteRenderer.transform.localScale = Vector3.Lerp (startScale, midScale, count / firstDuration);
				yield return null;
			}

			count = 0;

			while (count < firstDuration) {
				count += Time.deltaTime;

				spriteRenderer.transform.localScale = Vector3.Lerp (midScale, startScale, count / firstDuration);
				yield return null;
			}

			spriteRenderer.transform.localScale = startScale;
		}




		public void BallHit (Ball ball)
		{
			//Count--;
			_count--;
			number.text = _count.ToString ();
			Color = GetColorFromCount (_count);
			StartCoroutine (DOPunchScaleCoroutine (0.1f, 0.1f));

			if (Count <= 0) {
				if(OnDestroyedByBall != null)
					OnDestroyedByBall(this);

				Destroy (gameObject);
			}
		}
	}
}

