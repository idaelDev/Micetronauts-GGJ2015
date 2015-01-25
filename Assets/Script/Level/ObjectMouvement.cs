using UnityEngine;
using System.Collections;

public class ObjectMouvement : MonoBehaviour {
    Vector2 Impulsion;
	// Use this for initialization
	void Awake () {
       Impulsion = Random.insideUnitCircle.normalized * 100f;
       rigidbody2D.AddForce(Impulsion);
	}

}
