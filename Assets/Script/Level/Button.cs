using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
	public Activable activable;
	public bool isActivated = false;
	public Color validatingColor;
	private Color col;

	void Awake()
	{
		col = gameObject.renderer.material.color;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			isActivated = true;
			gameObject.renderer.material.color = validatingColor;
			activable.Activate();
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			isActivated = false;
			gameObject.renderer.material.color = col;
		}
	}
}
