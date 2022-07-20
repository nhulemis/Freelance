using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	// This value will change at the runtime depending on target movement. Initialize with zero vector.
	public float velocity = 50;
	public float smoothRotate = 50;
	public Vector3 offset;
	public bool ChaseEnable { get; set; } = true;

	public void Chase(Transform target)
	{
		print("folfoflfofofofofoof");
		if (!ChaseEnable)
		{
			return;
		}
		transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, velocity * Time.smoothDeltaTime);
		transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, smoothRotate * Time.smoothDeltaTime);
	}

	public void ChaseImmediate(Transform target)
	{
		transform.position = target.transform.position + offset;
		transform.rotation = target.rotation;
	}
}
