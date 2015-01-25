using UnityEngine;
using System.Collections;

public class PDoor : Activable {

	bool open = false;
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.battery && !open)
		{
			animation.Play();
			open = true;
		}
	}

	public override void Activate()
	{
		animation.Play();
	}
}
