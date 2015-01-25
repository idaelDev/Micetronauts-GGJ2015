using UnityEngine;
using System.Collections;

public abstract class Activable : MonoBehaviour {

	protected bool isActivated = false;

	public virtual void Activate()
	{
	}	
}
