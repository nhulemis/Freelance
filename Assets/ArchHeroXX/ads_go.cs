// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using GoogleMobileAds.Api;
// using UnityEditor;
//
// public class ads_go : MonoBehaviour {
// 	private BannerView bannerView;
// 	private InterstitialAd interstitial;
// 	private RewardBasedVideoAd rewardBasedVideo;
// 	private RewardedAd rewardedAd;
// 	private GameObject Rew;
//
// 	[Space]
// 	[Header("ADMOB ID:")]
// 	[Space]
// 	[Header("   *******************************************")]
// 	[Header("      Assets -> Google Mobile Ads -> Settings...")]
// 	[Header("   Do not forget to change the ADMOB APP ID in menu:")]
// 	[Header("   *******************************************")]
//
// 		public string appId;
//
// 		public string adUnitIdBanner;
// 		public string adUnitIdInter;
// 		public string adUnitIdReward;
// 		[Space]
// 	[Space]
// 		public bool showBanner;
// 		public float delayADS;
// 	[Space]
// [Space]
// 	public string redirectToScene;
//
//
//
//
//
//
// 	private float gameTimer;
// 	private string paramReward;
//
// 	private int loads;
//
//
//
//
//
// 	void checkOtherADS(){
// 		gameObject.name = "qwe";
//
// 		if (GameObject.Find("ADS")){
// 			Destroy(gameObject);
// 		}else{
// 			gameObject.name = "ADS";
// 		}
//
// 	}
//
// 	void Start () {
//
//
// 		checkOtherADS();
//
// 		DontDestroyOnLoad(this.gameObject);
//
// 		MobileAds.Initialize(appId);
//
// 		if (showBanner == true)
// 		{
// 			if (PlayerPrefs.GetInt("noads") != 1)
// 			{
// 				this.RequestBanner();
// 				bannerView.Show();
// 			}
// 		}
//
// 								this.rewardBasedVideo = RewardBasedVideoAd.Instance;
// 				        // Called when an ad request has successfully loaded.
// 				        rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
// 				        // Called when an ad request failed to load.
// 				        rewardBasedVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
// 				        // Called when an ad is shown.
// 				        rewardBasedVideo.OnAdOpening += HandleRewardBasedVideoOpened;
// 				        // Called when the ad starts to play.
// 				        rewardBasedVideo.OnAdStarted += HandleRewardBasedVideoStarted;
// 				        // Called when the user should be rewarded for watching a video.
// 				        rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
// 				        // Called when the ad is closed.
// 				        rewardBasedVideo.OnAdClosed += HandleRewardBasedVideoClosed;
// 				        // Called when the ad click caused the user to leave the application.
// 				        rewardBasedVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;
//
// 		RequestInterstitial();
// 		RequestRewardBasedVideo();
// 	}
//
//
// 	void Update(){
// 			gameTimer += Time.deltaTime;
//
// 			if (loads == 0){
// 					loads = 1;
// 					if (redirectToScene != "") Application.LoadLevel(redirectToScene);
// 			}
//
// 	}
//
// 	void ShowInterstitial()
// 	{
// 					if (PlayerPrefs.GetInt("noads") != 1 && gameTimer > delayADS)
// 					{
// 						if (this.interstitial.IsLoaded())
// 						{
// 							gameTimer = 0;
// 							this.interstitial.Show();
// 							RequestInterstitial();
// 						}
// 					}
//
//
// 	}
//
// 	public void ShowRewarded(string param)
// 	{
// 		paramReward = param;
//
// 		if (rewardBasedVideo.IsLoaded ()) {
// 			rewardBasedVideo.Show ();
// 			RequestRewardBasedVideo();
// 		}
// 	}
//
// 	void ShowBanner()
// 	{
// 		if (PlayerPrefs.GetInt("noads") != 1)
// 		{
// 			bannerView.Show();
// 		}
// 	}
//
// 	void HideBanner()
// 	{
// 		if (PlayerPrefs.GetInt("noads") != 1){
// 			bannerView.Hide();
// 			RequestBanner();
// 		}
// 	}
//
// 	private void RequestBanner()
// 	{
// 		this.bannerView = new BannerView(adUnitIdBanner, AdSize.Banner, AdPosition.Bottom);
// 		AdRequest request = new AdRequest.Builder().Build();
// 		bannerView.LoadAd(request);
// 		bannerView.Hide();
//
// 	}
// 	private void RequestInterstitial()
// 	{
// 		this.interstitial = new InterstitialAd(adUnitIdInter);
// 		AdRequest request = new AdRequest.Builder().Build();
// 		this.interstitial.LoadAd(request);
//
// 	}
// 	private void RequestRewardBasedVideo()
// 	{
// 		// Create an empty ad request.
// 		AdRequest request = new AdRequest.Builder().Build();
// 		// Load the rewarded video ad with the request.
// 		this.rewardBasedVideo.LoadAd(request, adUnitIdReward);
// 	}
//
//
// 	public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
//     {
//         MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
//     }
//
//     public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//     {
//
//     }
//
//     public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
//     {
//         MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
//     }
//
//     public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
//     {
//         MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
//     }
//
//
//
// 	public void HandleRewardBasedVideoRewarded(object sender, Reward args)
// 	{
//
// 		// 1 - GetIt extra time
// 		// 2 - receive x2 coins
// 		// 3 - menu chest
//
// 				if (paramReward == "GetResourcesPlayMode"){
//
//
//
// 				}
//
// 	}
//
//
// 		public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
// 	    {
//
//
// 	    }
//
//
// 				public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
// 			    {
//
// 			    }
//
// }
