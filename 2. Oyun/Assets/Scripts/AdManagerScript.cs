using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;


public class AdManagerScript : MonoBehaviour
{
    private RewardedAd rewardedAdGold;

    public Text goldText;
    public Text goldText2;
    private int gold;
    public Button addGoldButton;
    void Start()
    {

        gold = PlayerPrefs.GetInt("goldAmount");
        MobileAds.Initialize(initStatus => { });
     
        string adUnitId;
        #if UNITY_ANDROID
                adUnitId = "ca-app-pub-8609979031639976/6583770477";
#elif UNITY_IPHONE
                    adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
                    adUnitId = "unexpected_platform";
#endif


        this.rewardedAdGold = new RewardedAd(adUnitId);
        

        //--------------------------------------------------------------------------------------

        // Called when an ad request has successfully loaded.
        this.rewardedAdGold.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAdGold.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAdGold.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAdGold.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAdGold.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAdGold.OnAdClosed += HandleRewardedAdClosed;

       

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAdGold.LoadAd(request);
        addGoldButton.interactable = false;


    }
    

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
        addGoldButton.interactable=true;
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
        
        gold += 100;
        PlayerPrefs.SetInt("goldAmount", gold);
        goldText.GetComponent<Text>().text = gold.ToString("");
        goldText2.GetComponent<Text>().text = gold.ToString("");

    }
    public void writeGoldAmount()
    {
        PlayerPrefs.SetInt("goldAmount", gold);
        gold = PlayerPrefs.GetInt("goldAmount");
        goldText.GetComponent<Text>().text = gold.ToString("");
        goldText2.GetComponent<Text>().text = gold.ToString("");
    }
        
   
    public void showAdForGold()
    {
          if (rewardedAdGold.IsLoaded())
          {
              this.rewardedAdGold.Show();
          }
        
         /*
        gold += 10000;
        PlayerPrefs.SetInt("goldAmount", gold);
        writeGoldAmount();
         */
    }
    
   
    
}
