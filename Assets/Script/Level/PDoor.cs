using UnityEngine;
using System.Collections;

public class PDoor : Activable {

	public override void Activate()
	{
        if(!isActivated)
        {
		    animation.Play();
            GetComponent<AudioSource>().Play();
            isActivated = true;
        }
	}
}
