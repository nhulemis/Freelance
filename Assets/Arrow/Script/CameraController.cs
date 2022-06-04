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

	public static CameraController instance;
    private void Awake()
    {
		if (!instance) instance = this;
		else if (instance != this) Destroy(this.gameObject);
    }



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
	Vector3 newOfsset = new Vector3(0, 7, -10);

	public void finalChase(Transform target)
    {
		transform.position = Vector3.Lerp(transform.position, target.transform.position + newOfsset, velocity * Time.smoothDeltaTime);
	}

}
