using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsMethods : BasicAdNetwork
{
	#region Variables & Constants
	
	// name of Ad Network
	public const eAdsNetwork adNetwork = eAdsNetwork.UNITY;
	
	// key for android    
	public string androidID;
	
	// key for iOS    
	public string iOSID;
	
	// key for WP8
	//public string windowsID;
	
	#endregion
	#region Lifecycle methods
	
	// Use this for initialization
	void Start ()
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
		#endif
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
		}
	}

	public override bool isAdReady ()
	{

		return false;
	}

	public override eAdsNetwork GetAdNetworkInfo ()
	{ 
		return eAdsNetwork.UNITY;
	}
	#endregion
}