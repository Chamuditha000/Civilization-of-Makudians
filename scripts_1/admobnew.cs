using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class admobnew : MonoBehaviour
{
    public bool coinearned;
    public int tom ;
public int coinamount;
//private InterstitialAd interstitial_Ad;
private RewardedAd rewardedAd;
private timeshow timee;

//private string interstitial_Ad_ID;
private string rewardedAd_ID;
    // Start is called before the first frame update
    void Start()
    {tom=PlayerPrefs.GetInt("val");

        timee=GameObject.FindObjectOfType<timeshow>();
//interstitial_Ad_ID = "ca-app-pub-3940256099942544/1033173712";
rewardedAd_ID = "ca-app-pub-8250732486664823/7973491347";

MobileAds.Initialize (initstatus => { });

//RequestInterstitial ();
//RequestRewardedVideo ();
        
    }
void Update()
{
    if(timee.showhours<23 && timee.showhours>=0)
    {tom=PlayerPrefs.GetInt("val");
        tom=1;
        PlayerPrefs.SetInt("val",tom);
    }
tom=PlayerPrefs.GetInt("val");
    if (timee.showhours==23 && timee.showminutes == 29 && timee.showSeconds==5 && tom==1){
       RequestRewardedVideo ();
        ShowRewardedVideo();
        tom=0;
        PlayerPrefs.SetInt("val",tom);
       

        
    }
if(coinearned)
{
coinamount=PlayerPrefs.GetInt("camt");
coinamount+=200;
PlayerPrefs.SetInt("camt",coinamount);
coinearned=false;


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
     private void ShowRewardedVideo()
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
       RequestRewardedVideo ();
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        ShowRewardedVideo();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {


coinearned=true;
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }


}
