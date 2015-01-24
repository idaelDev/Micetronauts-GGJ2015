using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
	public bool isActivated = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			isActivated = true;
			gameObject.renderer.material.color = Color.green;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			isActivated = false;
			gameObject.renderer.material.color = Color.red;
		}
	}
}
