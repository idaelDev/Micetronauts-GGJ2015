using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{
	private CameraFollow cam;
	private Vector2 defaultGravity = new Vector2(0f, -9.81f);
	private bool isGravityOn = true;

	void Awake()
	{
		cam = GameObject.FindGameObjectWithTag(Tags.cam).GetComponent<CameraFollow>();
	}

	public void SwitchGravity()
	{
		if(isGravityOn){
			Physics2D.gravity = Vector2.zero;
			cam.followY = true;
		}
		else
		{
			Physics2D.gravity = defaultGravity;
			cam.followY = false;
		}
		isGravityOn = !isGravityOn;
	}

	public bool IsGravityOn
	{
		get
		{
			return isGravityOn;
		}
	}
}
