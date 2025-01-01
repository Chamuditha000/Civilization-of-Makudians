using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class earnlifeseeds : MonoBehaviour
{
public bool lifeseedsearned;
public int lifeseedsamount;
//private InterstitialAd interstitial_Ad;
private RewardedAd rewardedAd;

//private string interstitial_Ad_ID;
private string rewardedAd_ID;
    // Start is called before the first frame update
    void Start()
    {
//interstitial_Ad_ID = "ca-app-pub-3940256099942544/1033173712";
rewardedAd_ID ="ca-app-pub-8250732486664823/7973491347";

MobileAds.Initialize (initstatus => { });

//RequestInterstitial ();
RequestRewardedVideo ();
        
    }
void Update()
{
if(lifeseedsearned)
{
lifeseedsamount=PlayerPrefs.GetInt("lsamt");
lifeseedsamount+=100;
PlayerPrefs.SetInt("lsamt",lifeseedsamount);
lifeseedsearned=false;


}


}

   /* private void RequestInterstitial()
{
    interstitial_Ad = new InterstitialAd (interstitial_Ad_ID);
    interstitial_Ad.OnAdLoaded += HandleOnAdLoaded;
    AdRequest request = new AdRequest.Builder ().Build ();
    interstitial_Ad.Loaded (request);

}*/
     private void RequestRewardedVideo()
{
     rewardedAd = new RewardedAd (rewardedAd_ID);
     rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
     rewardedAd.OnAdClosed += HandleRewardedAdClosed;
     rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
     AdRequest request = new AdRequest.Builder ().Build ();
     rewardedAd.LoadAd (request);

}
    
/* public void ShowInterstitial()
{
     if (interstitial_Ad.IsLoaded())
     {
        interstitial_Ad.Show ();
        RequestInterstitial ();

     }

}*/
     public void ShowRewardedVideo()
{
     if(rewardedAd.IsLoaded())
      {
         rewardedAd.Show ();

      }


}
 public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
       RequestRewardedVideo();
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {ShowRewardedVideo();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {


lifeseedsearned=true;
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }

}

