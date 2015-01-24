using UnityEngine;
using System.Collections;

public class BrokenGlass : MonoBehaviour 
{
	public float explosionForce = 10f;
	public bool playOnAwake = true;

	private Rigidbody2D[] pieces;

	void Awake()
	{
		pieces = gameObject.GetComponentsInChildren<Rigidbody2D>();
		if(playOnAwake)
			Explode();
	}

	public void Explode()
	{
		Vector3 direction = Vector3.zero;
		for(int i=0; i< pieces.Length; i++)
		{
			direction = Random.insideUnitCircle;
			pieces[i].AddForce(direction.normalized * explosionForce);
		}
	}
}
