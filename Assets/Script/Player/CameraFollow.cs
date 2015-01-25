using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public Transform target;            // The position that that camera will be following.
	public float smoothing = 5f;        // The speed with which the camera will be following.
	public bool followY = false;
	public float yToTarget;

	Vector3 offset;                  // The initial offset from the target.
	
	void Start ()
	{
		// Calculate the initial offset.
		offset = transform.position - target.position;
	}
	
	void FixedUpdate ()
	{
		// Create a postion the camera is aiming for based on the offset from the target.
		float x = target.position.x + offset.x;
		float newPosX = Mathf.Lerp(transform.position.x, x, smoothing * Time.deltaTime);

		float y = yToTarget;
		float newPosY = 0;
		if(followY)
		{
			y = target.position.y + offset.y;
		}
		newPosY = Mathf.Lerp(transform.position.y, y, smoothing * Time.deltaTime);
		
		// Smoothly interpolate between the camera's current position and it's target position.
		transform.position =new Vector3(newPosX, newPosY, transform.position.z);
	}
}