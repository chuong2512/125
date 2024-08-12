// simple script for swapping between drawing modes

using UnityEngine;
using System.Collections;

namespace unitycoder_MobilePaint
{
	public class ToggleMode : MonoBehaviour {

		public GameObject canvas;
		public GameObject otherButton1;
		public GameObject otherButton2;

		public GameObject sizeGUI1;

		public DrawMode mode=DrawMode.Default;

		void OnMouseDown()
		{

			canvas.GetComponent<MobilePaint>().drawMode = mode;

		
			// toggle between default & no raycast
			sizeGUI1.layer = 2-sizeGUI1.layer;


		} // mousedown

	} // class
} // namespace