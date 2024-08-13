using UnityEngine;
using System.Collections;

public class DressupScene : BasePanel {

	private BaseItem itemToUnlock;
	public GameObject[] bodyList;
	public GameObject[] finsList;
	public GameObject[] eyesList;
	public GameObject[] hairsList;
	public GameObject[] tailsList;

	public GameObject bodyTxt;
	public GameObject eyeTxt;
	public GameObject finsTxt;
	public GameObject hairsTxt;
	public GameObject tailTxt;
	public GameObject eyeLash;
	public GameObject eyeBlink;
	public ParticleSystem  bubbles;
	public GameObject finalButtons;
	public GameObject[] itemToTurnOff;
	public GameObject nextBtn;

	void Start()
	{
		StartEyeBlinking();

		InitializeBodiesArray();
		InitializeEyesArray();
		InitializeFinsArray();
		InitializeHairsArray();
		InitializeTailsArray();
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

	void ShowBubbles()
	{
		//bubbles.emit = true;
		SoundManager.Instance.PlayBubblePushSound();
		Invoke("StopBubbles",5f);
	}

	void StopBubbles()
	{
		//bubbles.emit = false;
		SoundManager.Instance.StopInGameLoop();
	}

	public void InitializeBodiesArray ()
	{
		int i = 0;
		foreach (var Key in GameManager.Instance.bodyList.Keys) {
			if (!GameManager.Instance.bodyList [Key].isLocked) {
				bodyList [i].transform.GetChild (0).gameObject.SetActive (false);
			}
			i++;
		}
	}

	public void InitializeEyesArray ()
	{
		int i = 0;
		foreach (var Key in GameManager.Instance.eyesList.Keys) {
			if (!GameManager.Instance.eyesList [Key].isLocked) {
				eyesList [i].transform.GetChild (0).gameObject.SetActive (false);
			}
			i++;
		}
	}

	public void InitializeFinsArray ()
	{
		int i = 0;
		foreach (var Key in GameManager.Instance.finsList.Keys) {
			if (!GameManager.Instance.finsList [Key].isLocked) {
				finsList [i].transform.GetChild (0).gameObject.SetActive (false);
			}
			i++;
		}
	}

	public void InitializeHairsArray ()
	{
		int i = 0;
		foreach (var Key in GameManager.Instance.hairsList.Keys) {
			if (!GameManager.Instance.hairsList [Key].isLocked) {
				hairsList[i].transform.GetChild (0).gameObject.SetActive (false);
			}
			i++;
		}
	}

	public void InitializeTailsArray ()
	{
		int i = 0;
		foreach (var Key in GameManager.Instance.tailsList.Keys) {
			if (!GameManager.Instance.tailsList [Key].isLocked) {
				tailsList [i].transform.GetChild (0).gameObject.SetActive (false);
			}
			i++;
		}
	}
	public void BaseButtonsClicked(GameObject activeGrid,GameObject deActive1,GameObject deActive2,GameObject deActive3,GameObject deActive4)
	{
		SoundManager.Instance.PlayButtonClickSound();
		activeGrid.SetActive(true);
		deActive1.SetActive(false);
		deActive2.SetActive(false);
		deActive3.SetActive(false);
		deActive4.SetActive(false);
	}

	public void BodyItemClicked(GameObject item)
	{
		SoundManager.Instance.PlayButtonClickSound();
		itemToUnlock = GameManager.Instance.bodyList[item.name];

		if(itemToUnlock.isLocked)
		{
			AdvertisementManager.Instance.ShowAd(eAdsLoop.INCENTIVIZED);
		}
		else
		{
			ShowBubbles();
			bodyTxt.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Body/"+item.name);
			bodyTxt.GetComponent<UITexture>().MakePixelPerfect();
		}
		
	}

	public void EyesItemClicked(GameObject item)
	{
		SoundManager.Instance.PlayButtonClickSound();
		itemToUnlock = GameManager.Instance.eyesList[item.name];

		if(itemToUnlock.isLocked)
		{
			AdvertisementManager.Instance.ShowAd(eAdsLoop.INCENTIVIZED);
		}
		else
		{
			ShowBubbles();
			eyeTxt.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Eyes/"+item.name+"/base");
			eyeLash.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Eyes/"+item.name+"/blink1");
			eyeBlink.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Eyes/"+item.name+"/blink2");

			eyeTxt.GetComponent<UITexture>().MakePixelPerfect();
			eyeLash.GetComponent<UITexture>().MakePixelPerfect();
			eyeBlink.GetComponent<UITexture>().MakePixelPerfect();
		}
	}

	public void FinsItemClicked(GameObject item)
	{
		SoundManager.Instance.PlayButtonClickSound();
		itemToUnlock = GameManager.Instance.finsList[item.name];

		if(itemToUnlock.isLocked)
		{
			AdvertisementManager.Instance.ShowAd(eAdsLoop.INCENTIVIZED);
		}
		else
		{
			ShowBubbles();

			finsTxt.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Fins/"+item.name);
			finsTxt.GetComponent<UITexture>().MakePixelPerfect();

			finsTxt.GetComponent<TweenScale>().ResetToBeginning();
			finsTxt.GetComponent<TweenScale>().PlayForward();
		}
	}

	public void TailItemClicked(GameObject item)
	{
		SoundManager.Instance.PlayButtonClickSound();
		itemToUnlock = GameManager.Instance.tailsList[item.name];

		if(itemToUnlock.isLocked)
		{
			AdvertisementManager.Instance.ShowAd(eAdsLoop.INCENTIVIZED);
		}
		else
		{
			ShowBubbles();
			tailTxt.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Tails/"+item.name);
			tailTxt.GetComponent<UITexture>().MakePixelPerfect();

			tailTxt.GetComponent<TweenScale>().ResetToBeginning();
			tailTxt.GetComponent<TweenScale>().PlayForward();
		}
	}

	public void HairsItemClicked(GameObject item)
	{
		SoundManager.Instance.PlayButtonClickSound();
		itemToUnlock = GameManager.Instance.hairsList[item.name];

		if(itemToUnlock.isLocked)
		{
			AdvertisementManager.Instance.ShowAd(eAdsLoop.INCENTIVIZED);
		}
		else
		{
			ShowBubbles();
			hairsTxt.GetComponent<UITexture>().mainTexture = Resources.Load<Texture>("Hairs/"+item.name);
			hairsTxt.GetComponent<UITexture>().MakePixelPerfect();

			hairsTxt.GetComponent<TweenScale>().ResetToBeginning();
			hairsTxt.GetComponent<TweenScale>().PlayForward();
		}
	}

	public void NextBtnClicked()
	{
		GoogleAnalytics.LogScreenView("Final_FishMakeover");
		AdvertisementManager.Instance.ShowAd(eAdsLoop.MAINMENU);
		SoundManager.Instance.PlayButtonClickSound ();
		SoundManager.Instance.PlayBubblePushSound();
		//bubbles.emit = true;
		Invoke("StopBubbles",5f);

		foreach(GameObject obj in itemToTurnOff)
			obj.SetActive(false);
		finalButtons.SetActive(true);
	}

	public void RewardUser()
	{
		itemToUnlock.isLocked = false;

		InitializeBodiesArray();
		InitializeEyesArray();
		InitializeFinsArray();
		InitializeHairsArray();
		InitializeTailsArray();
	}

	public void ReplayBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PopMenuToState (GameNavigationController.GameState.BathScene);
	}

	public void HomeBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PopMenuToState (GameNavigationController.GameState.MainMenu);
	}

	public void ShareBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
	}

	public void RateusBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		Application.OpenURL("market://details?id=com.jingleapps.fishmakeover");
	}
}

