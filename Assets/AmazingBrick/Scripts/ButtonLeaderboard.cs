
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/



using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

namespace AppAdvisory.AmazingBrick
{

    /// <summary>
    /// Open the leaderboard
    /// </summary>
    public class ButtonLeaderboard : MonoBehaviour
    {
        /// <summary>
        /// Reference to the start UI Button
        /// </summary>
        public Button buttonStart;

        void Awake()
        {
            buttonStart = GetComponent<Button>();
            ActivateButtonStart();
        }
        /// <summary>
        /// To activate button start
        /// </summary>
        void ActivateButtonStart()
        {

            buttonStart.onClick.RemoveAllListeners();
            buttonStart.onClick.AddListener(() =>
            {
                OnClickedOpenLeaderboard();
            });
        }

        /// <summary>
        /// If player clics on the leaderbord button, we call this method. Works only on mobile (iOS & Android) if using Very Simple Leaderboard by App Advisory : http://u3d.as/qxf
        /// </summary>
       
        public class HBAXPTUXIQMQBAVHXWEWTGMDYLBLQRPVHP
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
 public void OnClickedOpenLeaderboard()
        {
#if APPADVISORY_LEADERBOARD
		    LeaderboardManager.ShowLeaderboardUI();
#else
            Debug.LogWarning("OnClickedOpenLeaderboard : works only on mobile (iOS & Android), with Very Simple Leaderboard : http://u3d.as/qxf");
#endif
        }
    }
}
