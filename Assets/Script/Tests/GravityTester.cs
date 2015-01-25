using UnityEngine;
using System.Collections;

public class GravityTester : MonoBehaviour {

	private GravityController gc;
	// Use this for initialization
	void Start () {
		gc = gameObject.GetComponent<GravityController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
			gc.SwitchGravity(!gc.IsGravityOn);
	}
}
