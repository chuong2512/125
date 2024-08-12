using UnityEngine;
using System.Collections;

public class SoapController : MonoBehaviour {

	public GameObject foam;
	public GameObject dirt;
	public GameObject objToNotify;

	public void ToolPressed()
	{
		gameObject.GetComponent<BoxCollider>().enabled = true;
	}

	public void ToolReleased()
	{
		gameObject.GetComponent<BoxCollider>().enabled = false;
	}

	void OnTriggerStay(Collider col)
	{
		if(col.name == dirt.name)
		{
			SoundManager.Instance.PlayShampooSound();
			foam.GetComponent<UITexture>().alpha += 0.0025f;

			if(foam.GetComponent<UITexture>().alpha >= 1)
			{
				SoundManager.Instance.StopInGameLoop();
				ToolReleased();
				dirt.SetActive(false);
				gameObject.transform.parent.GetComponent<BoxCollider>().enabled= false;
				gameObject.transform.parent.GetComponent<UIDragObject>().enabled= false;
				gameObject.transform.parent.GetComponent<TweenAlpha>().enabled= true;
				objToNotify.SendMessage("ToolApplyDone","Soap",SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.name == dirt.name)
		{
			SoundManager.Instance.StopInGameLoop();
		}
	}
}
