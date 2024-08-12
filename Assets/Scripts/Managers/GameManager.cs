using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
	#region Player
	// The Player
	public Player player;
	
	#endregion Player

	public Dictionary<string,BaseItem> bodyList;
	public Dictionary<string,BaseItem> eyesList;
	public Dictionary<string,BaseItem> finsList;
	public Dictionary<string,BaseItem> hairsList;
	public Dictionary<string,BaseItem> tailsList;

	#region Pause
	
	public bool isPaused = false;
	
	// The Sound Manager	
	public bool isSoundPaused;
	
	public void PauseGame ()
	{
		isPaused = true;
		Time.timeScale = 0.0f;
	}
	
	public void UnPauseGame ()
	{
		isPaused = false;
		Time.timeScale = 1.0f;
	}
	
	#endregion Pause
	
	#region Mono Life Cycle
	
	void Awake ()
	{
		
		if (GameObject.FindGameObjectsWithTag ("GameManager").Length > 1) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}
		
		GameManager.Instance.isSoundPaused = false;


		bodyList = DataProvider.GetBodyData();
		eyesList = DataProvider.GetEyesData();
		finsList = DataProvider.GetFinsData();
		hairsList = DataProvider.GetHairsData();
		tailsList = DataProvider.GetTailsData();
	}

	public void OnDestroy ()
	{
		if (GameObject.FindGameObjectsWithTag ("GameManager").Length < 1) {
			applicationIsQuitting = true;
		}
	}

	#endregion Mono Life Cycle

}
