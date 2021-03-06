using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class GoogleMobileAdsDeno : MonoBehaviour {    
	public static BannerView bannerView;
   
	public void Start()
	{
	#if UNITY_ANDROID
	string appId = "*******";
	#elif UNITY_IPHONE
	string appId = "******";
	#else
	string appId = "unexpected_platform";
	#endif

	// Initialize the Google Mobile Ads SDK.
	MobileAds.Initialize(appId);
       
        
    this.RequestBanner();
       
	}

	public void RequestBanner()
	{
	#if UNITY_ANDROID
	string adUnitId = "******";
#elif UNITY_IPHONE
	string adUnitId = "******";
#else
	string adUnitId = "unexpected_platform";
#endif
       
	// Create a 320x50 banner at the top of the screen.
	bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Called when an ad request has successfully loaded.
        bannerView.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        bannerView.OnAdOpening += HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        bannerView.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        bannerView.OnAdLeavingApplication += HandleOnAdLeavingApplication;
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
    
}
