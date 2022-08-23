
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/


using UnityEngine;
using System.Collections;

namespace AppAdvisory.AmazingBrick
{
	/// <summary>
	/// This script is disable. If you want to use it, enable it and add it to the camera. 
	/// This script handle zomm in and out according to player move.
	/// </summary>
	public class CameraZoomManager : MonoBehaviorHelper
	{
		//	Camera cam;
		//
		//	bool canZoom = true;
		//
		//	public bool desactivateZoom = true;
		//
		//	void Awake()
		//	{
		//		cam = GetComponent<Camera>();
		//	}
		//
		//	float GetDistance()
		//	{
		//		ObstacleLogic o = Util.GetNearestObstacle(ObjectPooling.Instance.obstacles,playerTransform);
		//
		//		if(o == null)
		//			return -1;
		//
		//		float dist = o.transform.position.y - playerTransform.position.y;
		//
		//		return dist;
		//	}
		//
		//	private float zoomSpeed
		//	{
		//		get
		//		{
		//			return 2f;
		//		}
		//	}
		//
		//	float lastUpdate = float.PositiveInfinity;
		//
		//	void FixedUpdate()
		//	{
		//		if(!canZoom || desactivateZoom)
		//			return;
		//		
		//		if(lastUpdate == float.PositiveInfinity)
		//		{
		//			lastUpdate = Time.realtimeSinceStartup;
		//
		//		}
		//
		//		float dist =  GetDistance();
		//
		//		if(dist <= 0)
		//			return;
		//
		//		cam.orthographicSize = Mathf.Lerp(cam.orthographicSize,  3f * countdownLogic.GetDistance(), 5 * zoomSpeed * Time.deltaTime);
		//	}
	}
}