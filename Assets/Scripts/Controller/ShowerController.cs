using UnityEngine;
using System.Collections;

public class ShowerController : MonoBehaviour {

	public GameObject foam;
	public GameObject objToNotify;
	public GameObject showerParticles;

	
	void OnTriggerStay(Collider col)
	{
		if(col.name == foam.name)
		{
			if(foam.GetComponent<UITexture>().alpha > 0)
			{
				foam.GetComponent<UITexture>().alpha -= 0.0025f;
			}
			else
			{
				gameObject.transform.parent.GetComponent<BoxCollider>().enabled= false;
				gameObject.transform.parent.GetComponent<UIDragObject>().enabled= false;
				gameObject.transform.parent.GetComponent<TweenAlpha>().enabled= true;
				ShowerReleased();
				objToNotify.SendMessage("ToolApplyDone","Shower",SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	
	public void ShowerPressed()
	{
		SoundManager.Instance.PlayShowerSound ();
		gameObject.GetComponent<BoxCollider> ().enabled = true;
	}

	public void ShowerReleased()
	{
		SoundManager.Instance.StopInGameLoop();
		gameObject.GetComponent<BoxCollider> ().enabled = false;
	}
}
