using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{

	public float speed = 5f;
	public string rightLegHorizontal = "Right Leg Horizontal Key";
	public string rightLegVertical = "Right Leg Vertical Key";
	public string leftLegHorizontal = "Left Leg Horizontal Key";
	public string leftLegVertical = "Left Leg Vertical Key";

	public string rightArmHorizontal = "Right Arm Horizontal Key";
	public string rightArmVertical = "Right Arm Vertical Key";
	public string leftArmHorizontal = "Left Arm Horizontal Key";
	public string leftArmVertical = "Left Arm Vertical Key";

	private GameObject footRight;
	private GameObject footLeft;
	private GameObject handRight;
	private GameObject handLeft;

	void Awake()
	{
		footRight = GameObject.FindGameObjectWithTag(Tags.footRight);
		footLeft = GameObject.FindGameObjectWithTag(Tags.footLeft);
		handRight = GameObject.FindGameObjectWithTag(Tags.handRight);
		handLeft = GameObject.FindGameObjectWithTag(Tags.handLeft);
	}

	void FixedUpdate()
	{
		float hFootRight = Input.GetAxis(rightLegHorizontal);
		float vFootRight = Input.GetAxis(rightLegVertical);
		float hFootLeft = Input.GetAxis(leftLegHorizontal);
		float vFootLeft = Input.GetAxis(leftLegVertical);

		float hHandRight = Input.GetAxis(rightArmHorizontal);
		float vHandRight = Input.GetAxis(rightArmVertical);
		float hHandLeft = Input.GetAxis(leftArmHorizontal);
		float vHandLeft = Input.GetAxis(leftArmVertical);

		MoveLegs(hFootRight, vFootRight, hFootLeft, vFootLeft);
		MoveArms(hHandRight, vHandRight, hHandLeft, vHandLeft);
	}

	void MoveLegs(float hFootRight, float vFootRight, float hFootLeft, float vFootLeft)
	{
		if(vFootRight > 0)
		{
			vFootLeft = 0;
		}
		else if(vFootLeft > 0)
		{
			vFootRight = 0;
		}
		Vector3 movement = new Vector3(hFootRight,vFootRight,0)*speed*Time.deltaTime;
		footRight.rigidbody2D.MovePosition(footRight.transform.position + movement);
		
		Vector3 movement2 = new Vector3(hFootLeft,vFootLeft,0)*speed*Time.deltaTime;
		footLeft.rigidbody2D.MovePosition(footLeft.transform.position + movement2);
	}

	void MoveArms(float hHandtRight, float vHandRight, float hHandLeft, float vHandLeft)
	{		
		Vector3 movement = new Vector3(hHandtRight,vHandRight,0)*speed*Time.deltaTime;
		handRight.rigidbody2D.MovePosition(handRight.transform.position + movement);
		
		Vector3 movement2 = new Vector3(hHandLeft,vHandLeft,0)*speed*Time.deltaTime;
		handLeft.rigidbody2D.MovePosition(handLeft.transform.position + movement2);

	}
}
