using UnityEngine;
using System.Collections;

public class EnterSpace : MonoBehaviour {
		
	public bool gravityOnTriggerEnter = true ;

	private GravityController gc;

	void Awake()
	{
		gc = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<GravityController>();
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.center)
		{
			gc.SwitchGravity(gravityOnTriggerEnter);
		}
	}
}
