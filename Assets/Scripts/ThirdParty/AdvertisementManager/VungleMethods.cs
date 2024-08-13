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
	}
	
	void OnDisable ()
	{
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
			break;

		default:
			break;
		}
	}

	public override bool isAdReady ()
	{
		return false;
	}

	public override eAdsNetwork GetAdNetworkInfo ()
	{ 
		return eAdsNetwork.VUNGLE;
	}
	
	#endregion


	#region Callbacks
	


	void HandleadPlayableEvent (bool isReady)
	{
	}

	void onAdStartedEvent ()
	{
		Debug.Log ("onAdStartedEvent");
	}

	#endregion
}
