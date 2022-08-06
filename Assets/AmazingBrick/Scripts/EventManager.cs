
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
	public class EventManager : MonoBehaviour
	{
		//	private static EventManager _instance;
		//	/// <summary>
		/// Delegate to store function subscribe by script who want to know when the game is started
		/// </summary>
		public delegate void GameStart ();
		public static event GameStart OnGameStarted;
		public static void DOGameStarted(){if(OnGameStarted!=null){OnGameStarted ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the game is ended
		/// </summary>
		public delegate void GameEnd ();
		public static event GameEnd OnGameEnded;
		public static void DOGameEnded(){if(OnGameEnded!=null){OnGameEnded ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player earns or uses one point or more
		/// </summary>
		public delegate void AddOnePoint ();
		public static event AddOnePoint OnAddOnePoint;
		public static void DOAddOnePoint(){if(OnAddOnePoint!=null){OnAddOnePoint ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player earns or uses one life or more
		/// </summary>
		public delegate void SetLife (int life);
		public static event SetLife OnSetLife;
		public static void DOSetLife(int life){if(OnSetLife!=null){OnSetLife (life);}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player earns or uses one diamond or more
		/// </summary>
		public delegate void setDiamond (int diamond);
		public static event setDiamond OnSetDiamond;
		public static void DOSetDiamond(int diamond){if(OnSetDiamond!=null){OnSetDiamond (diamond);}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the game set the best score
		/// </summary>
		public delegate void SetBestScore (int score);
		public static event SetBestScore OnSetBestScore;
		public static void DOSetBestScore(int score){if(OnSetBestScore!=null){OnSetBestScore (score);}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player fails
		/// </summary>
		public delegate void PlayerFail ();
		public static event PlayerFail OnPlayerFail;
		public static void DOPlayerFail(){if(OnPlayerFail!=null){OnPlayerFail ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player jumps
		/// </summary>
		public delegate void PlayerJump ();
		public static event PlayerJump OnPlayerJump;
		public static void DOPlayerJump(){if(OnPlayerJump!=null){OnPlayerJump ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player uses a game over button
		/// </summary>
		public delegate void GameOverButtons (bool _continue);
		public static event GameOverButtons OnClickedGameOverButtons;
		public static void DOClickedGameOverButtons(bool _continue){if(OnClickedGameOverButtons!=null){OnClickedGameOverButtons (_continue);}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the uses a game over button
		/// </summary>
		public delegate void PlayerHit ();
		public static event PlayerHit OnPlayerHit;
		public static void DOPlayerHit(){if(OnPlayerHit!=null){OnPlayerHit ();}}

		/// <summary>
		/// BETA
		/// </summary>
		public delegate void ItemSpaceTrap ();
		public static event ItemSpaceTrap OnJumpSpaceTrap;
		public static void DOItemSpaceTrap(){if(OnJumpSpaceTrap!=null){OnJumpSpaceTrap ();}}

		/// <summary>
		/// Delegate to store function subscribe by script who want to know when the player use a wrong selection on the UI
		/// </summary>
		public delegate void WrongSelection ();
		public static event WrongSelection OnWrongSelection;
		public static void DOWrongSelection(){if(OnWrongSelection!=null){OnWrongSelection ();}}


	}
}