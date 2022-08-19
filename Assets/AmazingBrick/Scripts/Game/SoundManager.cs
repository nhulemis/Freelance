
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using System.Collections;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// Class in charge to play musics and fx
	/// 
	/// Script attached to the "SoundManager" GameObject (child of the MainCamara). In charge to play musics and sound effects.
	/// 
	/// To Change a background music: Find the GameObject "Main Camera", and find the GameObject "SoundManager" and add your Audioclip music in the "Music Game" field. Same thing for the Music Menu; and for the FX sounds.
	/// </summary>
	public class SoundManager : MonoBehaviorHelper
	{
		/// <summary>
		/// Reference to the audio source use for music
		/// </summary>
		public AudioSource music;
		/// <summary>
		/// Reference to the audio source use for fx
		/// </summary>
		public AudioSource fx;

		/// <summary>
		/// Reference to the music use during the game
		/// </summary>
		public AudioClip musicGame;
		/// <summary>
		/// Reference to the music use in the menu
		/// </summary>
		public AudioClip musicMenu;

		/// <summary>
		/// Reference to the music use when the player touch an obstacle 
		/// </summary>
		public AudioClip musicGameOver;

		/// <summary>
		/// Reference to the fx played when the player jumps
		/// </summary>
		public AudioClip jumpFX;

		public AudioClip hitFX;

		public AudioClip jumpSpaceTrap;

		/// <summary>
		/// Reference to the fx played when the player earns a point
		/// </summary>
		public AudioClip coinFX;

		public AudioClip pointFX;

		public AudioClip wrongFX;

		void OnEnable()
		{
			EventManager.OnGameStarted += PlayMusicGame;
			EventManager.OnAddOnePoint += PlayPointFX;
			EventManager.OnSetDiamond += OnSetDiamond;
			EventManager.OnPlayerFail += PlayMusicGameOver;
			EventManager.OnPlayerJump += PlayJumpFX;
			EventManager.OnPlayerHit += PlayHit;
			EventManager.OnWrongSelection += PlayWrongFX;
			EventManager.OnJumpSpaceTrap += PlayJumpSpaceTrap;

			EventManager.OnClickedGameOverButtons += OnClickedGameOverButtons;
		}

		void OnDisable()
		{
			EventManager.OnGameStarted -= PlayMusicGame;
			EventManager.OnAddOnePoint -= PlayPointFX;
			EventManager.OnSetDiamond -= OnSetDiamond;
			EventManager.OnPlayerFail -= PlayMusicGameOver;
			EventManager.OnPlayerJump -= PlayJumpFX;
			EventManager.OnPlayerHit -= PlayHit;
			EventManager.OnWrongSelection -= PlayWrongFX;
			EventManager.OnJumpSpaceTrap -= PlayJumpSpaceTrap;

			EventManager.OnClickedGameOverButtons -= OnClickedGameOverButtons;
		}

		void OnClickedGameOverButtons(bool _continue)
		{
			if(_continue)
			{
				PlayMusicGame();
			}
		}

		void Start()
		{
			PlayMusicMenu ();
		}

		/// <summary>
		/// Play the music game
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

        public class JMRJPTAGNWUCAKGX
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
	public void PlayMusicGame()
		{
			music.volume = 1;


			PlayMusic (musicGame);
		}
		/// <summary>
		/// Play the music game over
		/// </summary>
		public void PlayMusicGameOver()
		{
			playFX (musicGameOver);
			music.volume = 0;
			//		music.DOFade(1,0);
		}
		/// <summary>
		/// Play the music menu
		/// </summary>
		public void PlayMusicMenu()
		{
			PlayMusic (musicMenu);
		}
		/// <summary>
		/// Play the jump fx
		/// </summary>
		public void PlayJumpFX()
		{
			playFX (jumpFX, 0.4f);
		}

		void OnSetDiamond(int i)
		{
			PlayCoinFX();
		}
		/// <summary>
		/// Play the coin fx
		/// </summary>
		public void PlayCoinFX()
		{
			playFX (coinFX, 0.4f);
		}

		public void PlayPointFX()
		{
			playFX (pointFX, 0.4f);
		}

		public void PlayWrongFX()
		{
			playFX (wrongFX, 1f);
		}

		public void PlayJumpSpaceTrap()
		{
			playFX (jumpSpaceTrap, 1f);
		}

		public void PlayHit()
		{
			playFX (hitFX, 1f);
		}

		/// <summary>
		/// Play an audioclip to be used with music audio source
		/// </summary>
	
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

        public class MLANQUYXKLH
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
	private void PlayMusic(AudioClip a)
		{
			if (music != null && music.clip != null)
				music.Stop ();


			music.clip = a;
			music.Play ();
		}

		/// <summary>
		/// Play an audioclip to be used with fx audio source
		/// </summary>
		private void playFX(AudioClip a)
		{
			playFX(a, 1f);
		}
		/// <summary>
		/// Play an audioclip to be used with fx audio source with a fixed volume 
		/// </summary>
		private void playFX(AudioClip a, float volume)
		{
			if (fx != null && fx.clip != null)
				fx.Stop ();

			fx.PlayOneShot (a, volume);
		}


		public void MuteAllMusic()
		{
			music.Pause();
			fx.Pause();
		}

		public void UnmuteAllMusic()
		{
			music.Play();
			fx.Play();
		}
	}
}