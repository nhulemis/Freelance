﻿//The MIT License (MIT)
//
//Copyright (c) 2015 Yifeng
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//	The above copyright notice and this permission notice shall be included in all
//	copies or substantial portions of the Software.
//
//	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//	SOFTWARE.
//


/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/



using UnityEngine;
using UnityEditor;
using System.Collections;

namespace LOS.Editor {

	public class LOSMenu : UnityEditor.Editor {

		[MenuItem("GameObject/LOS 2D Lighting/Radial Light", false, 50)]
		public static void CreateRadialLight () {
			CheckLOSCameraExistence();

			GameObject go = new GameObject("Radial Light");
			var light = go.AddComponent<LOSRadialLight>();

			light.material = Resources.Load<Material>("Materials/RadialLight");

			PlaceGameObjectAccordingToCamera(go);

			Selection.activeGameObject = go;
			Undo.RegisterCreatedObjectUndo(go, "Undo creating Radial Light");
		}

	
		[MenuItem("GameObject/LOS 2D Lighting/Full Screen Light", false, 51)]
		public static void CreateFullScreenForwardLight () {
			CheckLOSCameraExistence();
			
			GameObject go = new GameObject("Full Screen Light");
			var light = go.AddComponent<LOSFullScreenLight>();
			
			light.material = Resources.Load<Material>("Materials/Basic");

			PlaceGameObjectAccordingToCamera(go);

			Selection.activeGameObject = go;
			Undo.RegisterCreatedObjectUndo(go, "Undo creating Full Screen Light");
		}

		[MenuItem("GameObject/LOS 2D Lighting/Invert Full Screen Light", false, 52)]
		public static void CreateInvertFullScreenForwardLight () {
			CheckLOSCameraExistence();
			
			GameObject go = new GameObject("Invert Full Screen Light");
			var light = go.AddComponent<LOSFullScreenLight>();
			
			light.material = Resources.Load<Material>("Materials/Basic");
			light.invertMode = true;
			
			PlaceGameObjectAccordingToCamera(go);

			Selection.activeGameObject = go;
			Undo.RegisterCreatedObjectUndo(go, "Undo creating Invert Full Screen Light");
		}

		private static bool CheckLOSCameraExistence () {
			var losCameras = GameObject.FindObjectsOfType<LOSCamera>();

			bool result = losCameras.Length == 1;

			if (losCameras.Length == 0) {
				Debug.LogWarning("No LOSCamera found! We'll add the LOSCamera in the Camera.main. Change it if you need to.");
				Camera.main.gameObject.AddComponent<LOSCamera>();
				result = true;
			}
			else if (losCameras.Length > 1) {
				Debug.LogWarning("More than 2 LOSCamera are found in the scene! Please keep only 1 active.");
			}

			return result;
		}

		private static void PlaceGameObjectAccordingToCamera (GameObject go) {
			Camera editorCamera = SceneView.currentDrawingSceneView.camera;

			Vector3 position = editorCamera.transform.position;
			position.z = 0;
			editorCamera.transform.position = position;
		}

		
	}




}