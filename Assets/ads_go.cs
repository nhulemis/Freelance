using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ads_go : MonoBehaviour {
	
	private GameObject Rew;

	[Space]
	[Header("ADMOB ID:")]
	[Space]
	[Header("   *******************************************")]
	[Header("      Assets -> Google Mobile Ads -> Settings...")]
	[Header("   Do not forget to change the ADMOB APP ID in menu:")]
	[Header("   *******************************************")]

		public string appId;

		public string adUnitIdBanner;
		public string adUnitIdInter;
		public string adUnitIdReward;
		[Space]
	[Space]
		public bool showBanner;
		public float delayADS;
	[Space]
[Space]
	public string redirectToScene;






	private float gameTimer;
	private string paramReward;

	private int loads;





	void checkOtherADS(){
		gameObject.name = "qwe";

		if (GameObject.Find("ADS")){
			Destroy(gameObject);
		}else{
			gameObject.name = "ADS";
		}

	}

	void Start () {


		checkOtherADS();

		DontDestroyOnLoad(this.gameObject);

		

		RequestInterstitial();
		RequestRewardBasedVideo();
	}


	void Update(){
			gameTimer += Time.deltaTime;

			if (loads == 0){
					loads = 1;
					if (redirectToScene != "") Application.LoadLevel(redirectToScene);
			}

	}

	void ShowInterstitial()
	{
					if (PlayerPrefs.GetInt("noads") != 1 && gameTimer > delayADS)
					{
						
					}


	}

	public void ShowRewarded(string param)
	{
		paramReward = param;

		
	}

	void ShowBanner()
	{
		if (PlayerPrefs.GetInt("noads") != 1)
		{
		}
	}

	void HideBanner()
	{
		if (PlayerPrefs.GetInt("noads") != 1){
			RequestBanner();
		}
	}

	private void RequestBanner()
	{
		

	}
	private void RequestInterstitial()
	{
		

	}
	private void RequestRewardBasedVideo()
	{
		
	}


	public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
    }

  

    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }




		public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
	    {


	    }


				public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
			    {

			    }

}
