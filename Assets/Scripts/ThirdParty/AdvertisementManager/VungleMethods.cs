using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VungleMethods : BasicAdNetwork
{
	#region Variables
	
	// name of Ad Network
	public const eAdsNetwork adNetwork = eAdsNetwork.VUNGLE;
	
	// key for android    
	public string androidID;
	
	// key for iOS    
	public string iOSID;
	
	// key for WP8
	public string windowsID;

	#endregion
	#region Lifecycle methods

	// Use this for initialization
	void Start ()
	{

	}

	void OnEnable ()
	{
		Vungle.onAdStartedEvent += onAdStartedEvent;
		Vungle.adPlayableEvent += HandleadPlayableEvent;
		Vungle.onAdFinishedEvent += HandleonAdFinishedEvent;
	}
	
	void OnDisable ()
	{
		Vungle.onAdStartedEvent -= onAdStartedEvent;
		Vungle.adPlayableEvent -= HandleadPlayableEvent;
		Vungle.onAdFinishedEvent -= HandleonAdFinishedEvent;
	}

	#endregion

	#region Overriden Callback Methods
	
	public override void InitNetwork ()
	{   
		switch (configuration.adType) {
		case eAdsType.BANNER:
			
			break;                
		case eAdsType.INTERSTITIAL:

			break;                
		case eAdsType.VIDEO:
			GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Requested);
			Vungle.clearCache();
			Vungle.clearSleep();
			Vungle.init (androidID, iOSID, windowsID);
			break;

		case eAdsType.REWARDEDVIDEO:
			GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_IV_Requested);
			Vungle.clearCache();
			Vungle.clearSleep();
			Vungle.init (androidID, iOSID, windowsID);
			break;
		default:
			break;
		}
	}
	
	public override void ShowAd ()
	{   
		switch (configuration.adType) {
		case eAdsType.BANNER:
			
			break;                
		case eAdsType.INTERSTITIAL:

			break;                
		case eAdsType.VIDEO:
			Vungle.playAd (false);
			break;

		case eAdsType.REWARDEDVIDEO:
			Vungle.playAd (true);
			break;

		default:
			break;
		}
	}

	public override bool isAdReady ()
	{
		return Vungle.isAdvertAvailable ();
	}

	public override eAdsNetwork GetAdNetworkInfo ()
	{ 
		return eAdsNetwork.VUNGLE;
	}
	
	#endregion


	#region Callbacks
	


	void HandleadPlayableEvent (bool isReady)
	{
		if (isReady) {
			if (configuration.adType == eAdsType.REWARDEDVIDEO) {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_IV_Loaded);
			} else {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Loaded);
			}
		} else {
			if (configuration.adType == eAdsType.REWARDEDVIDEO) {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_IV_Failed);
			} else {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Failed);
			}
		}
	}

	void HandleonAdFinishedEvent (AdFinishedEventArgs adFinished)
	{
		if (adFinished.IsCompletedView) {
			if (configuration.adType == eAdsType.REWARDEDVIDEO) {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_IV_Completed);
			} else {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Completed);
			}
//			EmitShineParticles.Instance.EmitTheParticles();
			NGUITools.Broadcast ("RewardUser");
		} else if (adFinished.WasCallToActionClicked) {
			if (configuration.adType == eAdsType.REWARDEDVIDEO) {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_IV_Clicked);
			} else {
				GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Clicked);
			}
		} else {
			GoogleAnalytics.LogEvent (Constants.GA_CATEGORY_VUNGLE, Constants.GA_ACTION_NON_INCENTIVIZEDVIDEO, Constants.GA_LABEL_VUNGLE_NON_IV_Skipped);
		}
	}
	
	void onAdStartedEvent ()
	{
		Debug.Log ("onAdStartedEvent");
	}

	#endregion
}
