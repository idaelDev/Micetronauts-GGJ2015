using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{
	private CameraFollow cam;
	private Vector2 defaultGravity = new Vector2(0f, -9.81f);
	private bool isGravityOn = false;

	void Awake()
	{
		cam = GameObject.FindGameObjectWithTag(Tags.cam).GetComponent<CameraFollow>();
	}

	public void SwitchGravity(bool gravity)
	{
		if(gravity){
			Physics2D.gravity = Vector2.zero;
			cam.followY = true;
		}
		else
		{
			Physics2D.gravity = defaultGravity;
			cam.followY = false;
		}
		isGravityOn = gravity;
	}

	public bool IsGravityOn
	{
		get
		{
			return isGravityOn;
		}
	}
}
