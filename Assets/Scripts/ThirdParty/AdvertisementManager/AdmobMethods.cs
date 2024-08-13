using UnityEngine;
using System;
using System.Collections;

public class AdmobMethods : BasicAdNetwork
{

	#region Variables & Constants

	[System.Serializable]
	public class AdMobKeys : System.Object
	{
		public string bannerID;
		public string interstiaialID;
	}

	// name of Ad Network
	public const eAdsNetwork adNetwork = eAdsNetwork.ADMOB;

	// key for android
	public string androidID;

	// key for iOS
	public string iOSID;

	// key for Windows
	public string windowsID;

	private bool bannerAdLoaded = false;

	#endregion

	#region Lifecycle methods

	// Use this for initialization
	void Start ()
	{
		bannerAdLoaded = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	#endregion

	#region Overriden Callback Methods

	public override void InitNetwork ()
	{

#if UNITY_ANDROID
		string id = androidID;
#elif UNITY_IPHONE
        string id = iOSID;
#elif UNITY_WP8
		string id = windowsID;
#endif



		if (AdvertisementManager.Instance.bannerAdPosition == eBannerAdPosition.BOTTOM) {
		}
	}

	public override void ShowAd ()
	{
	
	}

	public override void HideAd ()
	{
		
	}

	public override eAdsNetwork GetAdNetworkInfo ()
	{ 
		return eAdsNetwork.ADMOB;
	}

	#endregion

	#region Banner callback handlers

	public void BannerAdLeftApplication (object sender, EventArgs args)
	{

	}

	public void BannerAdClosed (object sender, EventArgs args)
	{

	}

	public void BannerAdClosing (object sender, EventArgs args)
	{


	}

	public void BannerAdOpened (object sender, EventArgs args)
	{
		// log analytics
		}

	public void BannerAdLoaded (object sender, EventArgs args)
	{
		bannerAdLoaded = true;
		// Handle the ad loaded event.
		}



	#endregion
}
