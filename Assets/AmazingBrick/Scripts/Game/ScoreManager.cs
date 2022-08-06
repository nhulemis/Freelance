
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
	/// A script to handle the score and save the best score.
	/// </summary>
	public class ScoreManager 
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
		/// <summary>
		/// Save the score
		/// </summary>
		public static void SaveScore(int lastScore)
		{
			PlayerPrefs.SetInt ("LAST_SCORE", lastScore);

			int bestScore = PlayerPrefs.GetInt ("BEST_SCORE");

			if (lastScore > bestScore) {
				PlayerPrefs.SetInt ("BEST_SCORE", lastScore);
				PlayerPrefs.SetInt ("LAST_SCORE_IS_NEW_BEST", 1);
				return;
			}

			PlayerPrefs.SetInt ("LAST_SCORE_IS_NEW_BEST", 0);

		}

		/// <summary>
		/// Get the last score
		/// </summary>
		public static int GetLastScore()
		{
			return PlayerPrefs.GetInt ("LAST_SCORE");
		}

		/// <summary>
		/// Return true if the last score is a new best score
		/// </summary>
		public static bool GetLastScoreIsBest(){
			int temp = PlayerPrefs.GetInt ("LAST_SCORE_IS_NEW_BEST");
			if (temp == 1) {
				return true;
			}
			return false;
		}

		/// <summary>
		/// Get the best score
		/// </summary>
		public static int GetBestScore()
		{
			return PlayerPrefs.GetInt ("BEST_SCORE");
		}
	}
}