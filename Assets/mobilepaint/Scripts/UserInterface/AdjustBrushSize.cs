// simple GUITexture dragbar for brush size

using UnityEngine;
using System.Collections;

namespace unitycoder_MobilePaint
{

	public class AdjustBrushSize : MonoBehaviour {

		public GameObject painter; // our main paint plane reference

		private int minSize = 1; // min brush radius
		private int maxSize = 64; // max brush radius
		private float sizeScaler = 1; // temporary variable to calculate scale


		// init
		void Start () 
		{
			if (painter==null)
			{
				Debug.LogError("Painter gameObject not found - Have you assigned it?");
			}

			// calculate current indicator position
			minSize = painter.GetComponent<unitycoder_MobilePaint.MobilePaint>().brushSizeMin;
			maxSize = painter.GetComponent<unitycoder_MobilePaint.MobilePaint>().brushSizeMax;
		}


		// guitexture is dragged, update indicator position & brush size variable in painter gameobject
		void OnMouseDrag()
		{
		}
	}
}