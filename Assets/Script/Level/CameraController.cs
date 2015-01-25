using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float newYPosition = 0f;
	private CameraFollow cam;

	void Awake()
	{
		cam = GameObject.FindGameObjectWithTag(Tags.cam).GetComponent<CameraFollow>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.center)
		{
			cam.followY = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.center)
		{
			cam.followY = false;
			cam.yToTarget = newYPosition;
		}
	}

}
