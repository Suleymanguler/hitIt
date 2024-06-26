using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;
public class AdManagerScriptGem : MonoBehaviour
{
    private RewardedAd rewardedAdGem;

    public Text gemText;
    private int gem;
    void Start()
    {

        gem = PlayerPrefs.GetInt("gemAmount");
        MobileAds.Initialize(initStatus => { });

        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
                    adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
                    adUnitId = "unexpected_platform";
#endif


        this.rewardedAdGem = new RewardedAd(adUnitId);


        //--------------------------------------------------------------------------------------

        // Called when an ad request has successfully loaded.
        this.rewardedAdGem.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAdGem.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAdGem.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAdGem.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAdGem.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAdGem.OnAdClosed += HandleRewardedAdClosed;



        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAdGem.LoadAd(request);



    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: ");
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            message: "HandleRewardedAdFailedToShow event received with message: " + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        /* string type = args.Type;
         double amount = args.Amount;
         MonoBehaviour.print(
             "HandleRewardedAdRewarded event received for "
                         + amount.ToString() + " " + type);
        */

        gem += 5;
        PlayerPrefs.SetInt("gemAmount", gem);
        gemText.GetComponent<Text>().text = gem.ToString("");

    }


    public void showAdForGem()
    {
        if (rewardedAdGem.IsLoaded())
        {
            this.rewardedAdGem.Show();
        }

    }
}
