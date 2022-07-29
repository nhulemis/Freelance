using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace TunnelGame
{
	public class OverUI : MonoBehaviour
	{
		#region Inspector Variables

		[SerializeField] private Text scoreText;
		[SerializeField] private Text highScoreText;
		[SerializeField] private Text averageScoreText;
		[SerializeField] private Text coinsAmountText;

		#endregion

		#region Member Variables
		#endregion

		#region Properties
		#endregion

		#region Static Methods
		#endregion

		#region Unity Methods

		private void OnEnable()
		{
			scoreText.text			= GameManager.Instance.CurrentScore.ToString();
			highScoreText.text		= "HIGHSCORE: " + GameManager.Instance.HighScore;
			averageScoreText.text	= "AVERAGE: " + GameManager.Instance.AverageScore;
		}

		private void Update()
		{
			if (coinsAmountText.text != GameManager.Instance.DropsCollected.ToString())
			{
				// Coins amount could change if the player buys something on the player select screen
				coinsAmountText.text = GameManager.Instance.DropsCollected.ToString();
			}
		}

		#endregion
    public class LKAJSjqimxa
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class LKAJSjzcklx
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class ZKJvpoai
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class oxicuvA
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class CHJioawokca
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
	}
}
