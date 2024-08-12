using UnityEngine;
using System.Collections;
using unitycoder_MobilePaint;

public class MyColoringScript : BasePanel {

	public GameObject bubblePush;
	public GameObject starFishBtn;
	public GameObject blinkEye;
	public static MobilePaint mobilePaint;
	public Color[] colors;
	public GameObject[] brushSizes;
	
	void Start()
	{
//		UniversalAnalytics.LogScreenView("Coloring Scene");
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

	public void ColorClicked(GameObject item)
	{
		mobilePaint.paintColor = colors [(int.Parse (item.name))-1];
	}
	
	public void BrushSizeClicked(GameObject brush)
	{
		SoundManager.Instance.PlayButtonClickSound();
		mobilePaint.brushSize = int.Parse(brush.name);
		
	}
	
	public void EraserClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();
		mobilePaint.paintColor = colors[30];
		mobilePaint.drawMode = DrawMode.Default;
	}
	
	public void FloodFillBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();
		mobilePaint.drawMode = DrawMode.FloodFill;
	}
	
	public void BrushBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();
		mobilePaint.drawMode = DrawMode.Default;
		mobilePaint.paintColor = colors [0];
		mobilePaint.brushSize = 30;
	}

	public void PencilBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound();
		mobilePaint.drawMode = DrawMode.Default;
		mobilePaint.brushSize = 2;
	}

	public void NextBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.BaloonScene);
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
