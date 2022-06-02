using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
	[Header("Object to follow")]
	public GameObject targetToFollow;

	[Header("Follow speed")]
	[Range(0f, 50f)]
	public float speed = 6f;

	[Header("Camera Offset")]
	[Range(-10f, 10f)]
	public float yOffset;

	[Range(-10f, 10f)]
	public float xOffset;

	public void convert()
	{
		float fValue = 0.123456f;
		int iValue = (int)fValue;
		Debug.Log("int val: " +iValue);
         
		// iValue = Mathf.FloorToInt(fValue);
		// Debug.Log("int val: " +iValue);
  //        
		// iValue = Mathf.CeilToInt(fValue);
		// Debug.Log("int val: " +iValue);
  //        
		// iValue = Mathf.RoundToInt(fValue);
		// Debug.Log("int val: " +iValue);
	}
	[Space(15f)]
	public UIManager uIManager;

	[Space(15f)]
	public Animator anim;

	private float interpolation;

	private Vector3 position;

	private bool active;

	public void EnableDisableFollow(bool status)
	{
		active = status;
	}
	// public void convert()
	// {
	// 	float fValue = 0.123456f;
	// 	int iValue = (int)fValue;
	// 	Debug.Log("int val: " +iValue);
 //         
	// 	iValue = Mathf.FloorToInt(fValue);
	// 	Debug.Log("int val: " +iValue);
 //         
	// 	iValue = Mathf.CeilToInt(fValue);
	// 	Debug.Log("int val: " +iValue);
 //         
	// 	iValue = Mathf.RoundToInt(fValue);
	// 	Debug.Log("int val: " +iValue);
	// }

	private void LateUpdate()
	{
		if (uIManager.gameState == GameState1.PLAYING && active)
		{
			interpolation = speed * Time.deltaTime;
			position = base.transform.position;
			if (targetToFollow.transform.position.y + yOffset > base.transform.position.y)
			{
				position.y = Mathf.Lerp(base.transform.position.y, targetToFollow.transform.position.y + yOffset, interpolation);
				position.x = Mathf.Lerp(base.transform.position.x, targetToFollow.transform.position.x + xOffset, interpolation);
			}
			base.transform.position = position;
		}
	}

	public void ShakeCamera()
	{
		anim.Play("CameraShake");
	}
}
