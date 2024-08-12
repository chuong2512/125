using UnityEngine;
using System.Collections;

public class BathScene : BasePanel {


	public GameObject eyeLash;
	public GameObject eyeBlink;
	public GameObject soapApplier;
	public GameObject showerApplier;
	public GameObject nextBtn;


	void Start()
	{
		GoogleAnalytics.LogScreenView("BathScene_FishMakeover");
		AdvertisementManager.Instance.ShowBannerAd();
		AdvertisementManager.Instance.ShowAd(eAdsLoop.MAINMENU);

		SoundManager.Instance.PlayBubblePushSound();
		StartEyeBlinking();
		Invoke("StopBubbles",5f);
	}

	void StopBubbles()
	{
		SoundManager.Instance.StopInGameLoop();
	}

	void StartEyeBlinking ()
	{
		eyeBlink.SetActive (true);
		eyeLash.SetActive (false);
		Invoke("BlinkEye",0.1f);
	}

	void BlinkEye()
	{
		eyeBlink.SetActive (false);
		eyeLash.SetActive (true);
		Invoke("StartEyeBlinking",3.5f);
	}


	public void ToolApplyDone(string toolName)
	{
		if(toolName == "Brush")
		{
			soapApplier.SetActive(true);
		}
		else if(toolName == "Soap")
		{
			showerApplier.SetActive(true);
		}
		else if(toolName == "Shower")
		{
			SoundManager.Instance.PlayBubblePushSound();
			Invoke("StopBubbles",5f);
			nextBtn.SetActive(true);
		}
	}

	public void NextBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		SoundManager.Instance.StopInGameLoop();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.DressupScene);
	}

}
