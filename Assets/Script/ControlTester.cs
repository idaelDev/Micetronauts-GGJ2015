using UnityEngine;
using System.Collections;

public class ControlTester : MonoBehaviour {

	public float hFootRight;
	public float vFootRight;
	public float hFootLeft;
	public float vFootLeft;

	public float hHandRight;
	public float vHandRight;
	public float hHandLeft;
	public float vHandLeft;

	public string rightLegHorizontal = "Right Leg Horizontal Key";
	public string rightLegVertical = "Right Leg Vertical Key";
	public string leftLegHorizontal = "Left Leg Horizontal Key";
	public string leftLegVertical = "Left Leg Vertical Key";

	public string rightArmHorizontal = "Right Arm Horizontal Key";
	public string rightArmVertical = "Right Arm Vertical Key";
	public string leftArmHorizontal = "Left Arm Horizontal Key";
	public string leftArmVertical = "Left Arm Vertical Key";

	void Update()
	{
		  hFootRight = Input.GetAxis(rightLegHorizontal);
		  vFootRight = Input.GetAxis(rightLegVertical);
		  hFootLeft = Input.GetAxis(leftLegHorizontal);
		  vFootLeft = Input.GetAxis(leftLegVertical);

		hHandRight = Input.GetAxis(rightArmHorizontal);
		vHandRight = Input.GetAxis(rightArmVertical);
		
		hHandLeft = Input.GetAxis(leftArmHorizontal);
		vHandLeft = Input.GetAxis(leftArmVertical);
	}
}
