using UnityEngine;
using System.Collections;

public class Trappe : Activable {



	public override void Activate()
	{
        if(!isActivated)
        {
		    gameObject.GetComponent<Animation>().Play();
            gameObject.GetComponent<AudioSource>().Play();
            isActivated = true;
        }
	}

}
