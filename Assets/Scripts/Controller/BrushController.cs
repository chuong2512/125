using UnityEngine;
using System.Collections;

public class BrushController : MonoBehaviour {

	private int counter=0;
	public GameObject objToNotify;
	public GameObject handPointer;

	void OnPress(bool isPress)
	{
		if(isPress)
		{
			handPointer.SetActive(false);
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "leaf")
		{
			col.enabled = false;
			col.GetComponent<Rigidbody>().useGravity = true;
			counter++;

			if(counter == 7)
			{

				gameObject.GetComponent<BoxCollider>().enabled= false;
				gameObject.GetComponent<UIDragObject>().enabled= false;
				gameObject.GetComponent<TweenAlpha>().enabled= true;
				objToNotify.SendMessage("ToolApplyDone","Brush",SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
