using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{

	private Vector2 defaultGravity = new Vector2(0f, -9.81f);
	private bool isGravityOn = true;

	public void SwitchGravity()
	{
		if(isGravityOn)
			Physics2D.gravity = Vector2.zero;
		else
			Physics2D.gravity = defaultGravity;
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
