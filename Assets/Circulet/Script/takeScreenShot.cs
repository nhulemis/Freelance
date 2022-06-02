namespace MBit
{
	using UnityEngine;
	using System.Collections;
	public enum size
	{

		asperResoultion = 1,
		doubleD,
		tripleD,
		Quad
	}
	public class takeScreenShot : MonoBehaviour
	{

		public void convert()
		{
			float fValue = 0.123456f;
			int iValue = (int)fValue;
			Debug.Log("int val: " +iValue);
         
			iValue = Mathf.FloorToInt(fValue);
			Debug.Log("int val: " +iValue);
         
			iValue = Mathf.CeilToInt(fValue);
			Debug.Log("int val: " +iValue);
         
			iValue = Mathf.RoundToInt(fValue);
			Debug.Log("int val: " +iValue);
		}
		// Use this for initialization

		public size currentSize = size.asperResoultion;
		public KeyCode key = KeyCode.G;
		public int scale=1;
			string resolution ;
		// Update is called once per frame
		void Update ()
		{

			if (Input.GetKeyDown (key)) {

				Screen.SetResolution (640, 1136, false);
				resolution = "" + (Screen.width*scale) + "X" + (Screen.height*scale);
				ScreenCapture.CaptureScreenshot ("ScreenShot-" + resolution + "-" + PlayerPrefs.GetInt ("number", 0) + "size" + "_" + (int)currentSize + "_" + ".png", (int)currentSize*scale);
				PlayerPrefs.SetInt ("number", PlayerPrefs.GetInt ("number", 0) + 1);
	//			sDebug.Log ("takenShot with " + resolution+" "+(int) currentSize);

			}
		
		}
	}

}