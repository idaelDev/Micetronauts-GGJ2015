using UnityEngine;
using System.Collections;

public class Trappe : Activable {



	public override void Activate()
	{
		gameObject.GetComponent<Animation>().Play();
	}

}
