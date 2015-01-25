using UnityEngine;
using System.Collections;

public class ObjectMouvement : MonoBehaviour {
    Vector2 Impulsion;
	// Use this for initialization
	void Awake () {
       Impulsion = Random.insideUnitCircle.normalized * 100f;
       rigidbody2D.AddForce(Impulsion);
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == Tags.floor)
		{
//			rigidbody2D.velocity *= 2f;
		}
	}
}
