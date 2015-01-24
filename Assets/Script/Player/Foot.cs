using UnityEngine;
using System.Collections;

public class Foot : MonoBehaviour 
{
	public bool isOnFloor = true;

	void OnCollisionStay(Collision other)
	{
		if(other.gameObject.tag == Tags.floor)
		{
			isOnFloor = true;
		}
	}

	void OnCollisionExit(Collision other)
	{
		if(other.gameObject.tag == Tags.floor)
		{
			isOnFloor = false;
		}
	}
}
