using UnityEngine;
using System.Collections;

public class MemberControl : MonoBehaviour 
{
	public bool canControl = true;
	public bool isOnFloor = false;

	private float height = 0;
	private float maxUp;

//	void FixedUpdate()
//	{
////		if(!canControl)
////		{
////			rigidbody2D.AddForce(new Vector2(0,-15));
////		}
//	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag != Tags.body)
		{
			isOnFloor = true;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.tag != Tags.body)
		{
			isOnFloor = false;
		}
	}
}
