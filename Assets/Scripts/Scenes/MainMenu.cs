using UnityEngine;
using System.Collections;

public class MainMenu : BasePanel {

	public GameObject eyeLash;
	public GameObject eyeLash2;
	public GameObject eyeBlink;
	public GameObject eyeBlink2;
	//public ParticleEmitter bubbles;

	void Start()
	{
		GoogleAnalytics.LogScreenView("MainMenu_FishMakeover");
	
		SoundManager.Instance.PlayBubblePushSound();
		StartEyeBlinking();
		StartEyeTwoBlinking();

		Invoke("StopBubbles",5f);
	}

	void StopBubbles()
	{
		//bubbles.emit = false;
		SoundManager.Instance.StopInGameLoop();
	}

	void StartEyeTwoBlinking()
	{
		eyeBlink2.SetActive (true);
		eyeLash2.SetActive (false);
		Invoke("BlinkEye2",0.1f);
	}

	void BlinkEye2()
	{
		eyeBlink2.SetActive (false);
		eyeLash2.SetActive (true);
		Invoke("StartEyeTwoBlinking",3f);
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

	public void PlayBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();
		SoundManager.Instance.StopInGameLoop();
		GameNavigationController.Instance.PushPanel(GameNavigationController.GameState.BathScene);
	}
		



}
