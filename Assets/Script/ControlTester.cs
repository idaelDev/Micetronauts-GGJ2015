using UnityEngine;
using System.Collections;

public class ControlTester : MonoBehaviour {

	public float hFootRight;
	public float vFootRight;
	public float hFootLeft;
	public float vFootLeft;

	public string rightLegHorizontal = "Right Leg Horizontal Key";
	public string rightLegVertical = "Right Leg Vertical Key";
	public string leftLegHorizontal = "Left Leg Horizontal Key";
	public string leftLegVertical = "Left Leg Vertical Key";

	void Update()
	{
		  hFootRight = Input.GetAxis(rightLegHorizontal);
		  vFootRight = Input.GetAxis(rightLegVertical);
		  hFootLeft = Input.GetAxis(leftLegHorizontal);
		  vFootLeft = Input.GetAxis(leftLegVertical);
	}
}
