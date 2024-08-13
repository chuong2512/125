using UnityEngine;
using System.Collections;
using System.IO;

public class CaptureGalleryScreenshot : Singleton<CaptureGalleryScreenshot> {
	
	// Use this for initialization
	void Start () {
	}

	public void TakeScreenshot()
	{
		}

	void ScreenshotSaved()
	{
		Debug.Log ("Screenshot finished saving");
	}
	
	void ImageSaved()
	{
		Debug.Log ("Finished saving Image");
	}
}
