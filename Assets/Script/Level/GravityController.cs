using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{

	public float gravityZ = 8f;
	public float noGravityZ = 5.5f;
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
			cam.zToTarget = gravityZ;
		}
		else
		{
			Physics2D.gravity = defaultGravity;
			cam.followY = false;
			cam.zToTarget = noGravityZ;
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
