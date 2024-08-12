using UnityEngine;
using System.Collections;

public class MyDestroyObject : MonoBehaviour {

	public float destroyTime;

	void Start () {
	
		Invoke ("DestroyMyObject",destroyTime);
	}

	void DestroyMyObject()
	{
		Destroy (transform.gameObject);
	}
}
