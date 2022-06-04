// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class AdManager : MonoBehaviour
// {
//     public static AdManager instance;
//
//     //Private Data
//     private bool skipLevel;
//     private bool claimReward;
//
//     private void Awake()
//     {
//         if (!instance) instance = this;
//         else if (instance != this) Destroy(this.gameObject);
//
//         //Ads Init
//         Advertisements.Instance.Initialize();
//     }
//
//     // Start is called before the first frame update
//     void Start()
//     {
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//     }
//
//     public void showInter()
//     {
//         hideBanner();
//         if (Advertisements.Instance.IsInterstitialAvailable())
//         {
//             Advertisements.Instance.ShowInterstitial();
//         }
//         else if (Advertisements.Instance.IsRewardVideoAvailable())
//         {
//             Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//         }
//     }
//
//     public void showReward()
//     {
//         if (Advertisements.Instance.IsRewardVideoAvailable())
//         {
//             Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//         }
//         else if (Advertisements.Instance.IsInterstitialAvailable())
//         {
//             Advertisements.Instance.ShowInterstitial();
//         }
//     }
//
//
//     private void CompleteMethod(bool completed, string advertiser)
//     {
//         Debug.Log("Closed rewarded from: " + advertiser + " -> Completed " + completed);
//         if (completed == true)
//         {
//             if (skipLevel)
//             {
//                 skipLevel = false;
//                 UiManager.instance.updateCurrentLevel();
//                 UiManager.instance.next();
//             }
//             else if (claimReward)
//             {
//                 claimReward = false;
//                 UiManager.instance.rewardCoinClaimed();
//             }
//             //give the reward
//         }
//         else
//         {
//             if (skipLevel)
//             {
//                 skipLevel = false;
//             }
//             else if (claimReward)
//             {
//                 claimReward = false;
//             }
//             //no reward
//         }
//     }
//
//     public void showBanner()
//     {
//         Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
//     }
//
//     public void hideBanner()
//     {
//         if (Advertisements.Instance.IsBannerOnScreen())
//         {
//             Advertisements.Instance.HideBanner();
//         }
//     }
//
//     public void skipLevelReward()
//     {
//         if (Advertisements.Instance.IsRewardVideoAvailable())
//         {
//             skipLevel = true;
//             Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//         }
//     }
//
//     public void claimRewardCoin()
//     {
//         if (Advertisements.Instance.IsRewardVideoAvailable())
//         {
//             claimReward = true;
//             Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//         }
//     }
// }