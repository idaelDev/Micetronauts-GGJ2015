using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour 
{
	public float strenght = 100f;

	void OnTriggerStay2D(Collider2D other)
	{
		Vector3 direction = transform.position - other.gameObject.transform.position;
		other.rigidbody2D.AddForce(direction * strenght * Time.deltaTime);
	}

}
