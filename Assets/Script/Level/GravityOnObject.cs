using UnityEngine;
using System.Collections;

public class GravityOnObject : MonoBehaviour {
	private float defaultGravity = 1;
	private bool isGravityOn = true;
	
	public void SwitchGravity()
	{
		if(isGravityOn)
			rigidbody2D.gravityScale = 0;
		else
			rigidbody2D.gravityScale = defaultGravity;
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
