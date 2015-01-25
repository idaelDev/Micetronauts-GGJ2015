using UnityEngine;
using System.Collections;

public class ObjectMouvement : MonoBehaviour {
    Vector2 Impulsion;
	// Use this for initialization
	void Start () {
       Impulsion = new Vector2 (Random.Range(-100F, 100F),Random.Range(-100F, 100f));
       rigidbody2D.AddForce(Impulsion);
	
	}
	
	// Update is called once per frame
	void Update () {
   
	}
}
