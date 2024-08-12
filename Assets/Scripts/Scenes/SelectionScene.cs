using UnityEngine;
using System.Collections;

public class SelectionScene : BasePanel {


	void Start()
	{

	}

	public void BathSceneClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.BathScene);
	}

	public void DressupSceneClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.DressupScene);
	}

	public void BaloonsClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.BaloonScene);
	}

	public void ColoringClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PushPanel (GameNavigationController.GameState.Coloring);
	}

	public void HomeBtnClicked()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		GameNavigationController.Instance.PopMenuToState (GameNavigationController.GameState.MainMenu);
	}
		
}
