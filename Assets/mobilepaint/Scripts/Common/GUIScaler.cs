// basic scale guitexture or guitext to fix its size in HD devices

using UnityEngine;
using System.Collections;

namespace unitycoder_MobilePaint_samples
{

	public class GUIScaler : MonoBehaviour 
	{
		private float scaleAdjust = 1.0f;

		private const float BASE_WIDTH = 800;
		private const float BASE_HEIGHT = 480;

		void Awake()
		{
			float _baseHeightInverted = 1.0f/BASE_HEIGHT;
			float ratio = (Screen.height * _baseHeightInverted)*scaleAdjust;



			// no need anymore
			Destroy(this);

		}
	}
}