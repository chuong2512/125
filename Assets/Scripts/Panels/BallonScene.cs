using UnityEngine;
using System.Collections;

public class BallonScene : BasePanel {

	public GameObject bubblePush;
	public GameObject starFishBtn;
	public GameObject handPointer;
	public GameObject handPointer2;
	public GameObject blinkEye;

	void Start()
	{
//		UniversalAnalytics.LogScreenView("Baloon Scene");
		StartEyeBlinking ();
	
	}

	void StartEyeBlinking ()
	{
		blinkEye.SetActive (true);
		Invoke("BlinkEye",0.2f);
	}
	
	void BlinkEye()
	{
		blinkEye.SetActive (false);
		Invoke("StartEyeBlinking",2.5f);
	}

	public void CoverClicked(GameObject cover)
	{
		handPointer.GetComponent<TweenAlpha> ().PlayReverse();
		cover.GetComponent<TweenAlpha> ().PlayForward();

		if (cover.name == "cover2")
			handPointer2.SetActive (true);
	}

	public void NextBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.BathScene);
	}


	public void HomeBtnClicked()
	{

		SoundManager.Instance.PlayButtonClickSound ();
		SoundManager.Instance.StopInGameLoop ();
		GameNavigationController.Instance.PopMenuToState (GameNavigationController.GameState.SelectionScene);
	}

	public void StarFishButtonClicked()
	{

		SoundManager.Instance.PlayButtonClickSound ();
		SoundManager.Instance.PlayBubblePushSound ();
		starFishBtn.GetComponent<BoxCollider> ().enabled = false;
		starFishBtn.GetComponent<UITexture> ().alpha = 0.5f;

		Invoke ("DisablePubblePush",6f);
		Invoke ("EnableFishButton",12f);

	}

	void EnableFishButton()
	{
		starFishBtn.GetComponent<BoxCollider> ().enabled = true;
		starFishBtn.GetComponent<UITexture> ().alpha = 1f;
	}

	void DisablePubblePush()
	{
		SoundManager.Instance.StopInGameLoop ();
	}

	public void OnFacebookButtonClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();

	}
	

}
