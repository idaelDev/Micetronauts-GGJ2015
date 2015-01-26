using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public Transform target;            // The position that that camera will be following.
	public float smoothing = 5f;        // The speed with which the camera will be following.
	public bool followY = false;
	public float yToTarget;
	public float xoffset = 0;
	public float gravityZ = 8f;
	public float noGravityZ = 5.5f;

	public float zToTarget = 5.5f;
	Vector3 offset;                  // The initial offset from the target.
	private Camera cam;

	void Start ()
	{
		// Calculate the initial offset.
		cam = GetComponent<Camera>();
	}
	
	void FixedUpdate ()
	{
		// Create a postion the camera is aiming for based on the offset from the target.
		float x = target.position.x + xoffset;
		float newPosX = Mathf.Lerp(transform.position.x, x, smoothing * Time.deltaTime);

		float y = yToTarget;
		float newPosY = 0;
		if(followY)
		{
			y = target.position.y + offset.y;
		}
		newPosY = Mathf.Lerp(transform.position.y, y, smoothing * Time.deltaTime);

		float z = zToTarget;
		float newPosZ =  Mathf.Lerp(cam.orthographicSize, z, smoothing * Time.deltaTime);

		cam.orthographicSize = newPosZ;
		// Smoothly interpolate between the camera's current position and it's target position.
		transform.position =new Vector3(newPosX, newPosY, transform.position.z);
	}
}