using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public bool twoPlayer = false;

	public bool player1_keyboard = false;
	public bool player2_keyboard = false;
	public bool player3_keyboard = false;
	public bool player4_keyboard = false;

	public float speed = 5f;
	public float gravitySpeed = 100f;

	private string rightLegHorizontal;
	private string rightLegVertical;

	private string leftLegHorizontal;
	private string leftLegVertical;

	private string rightArmHorizontal;
	private string rightArmVertical;

	private string leftArmHorizontal;
	private string leftArmVertical;

	private GameObject gameController;
	private GravityController gravityController;

	private GameObject footRightObject;
	private GameObject footLeftObject;
	private GameObject handRightObject;
	private GameObject handLeftObject;
	private MemberControl footRight;
	private MemberControl footLeft;
	private MemberControl handRight;
	private MemberControl handLeft;

	void Awake()
	{
		gameController = GameObject.FindGameObjectWithTag(Tags.gameController);
		gravityController = gameController.GetComponent<GravityController>();
//		footRightObject = GameObject.FindGameObjectWithTag(Tags.footRight);
		footRightObject = GameObject.Find("Foot_Right");
//		footLeftObject = GameObject.FindGameObjectWithTag(Tags.footLeft);
		footLeftObject = GameObject.Find("Foot_Left");
//		handRightObject = GameObject.FindGameObjectWithTag(Tags.handRight);
		handRightObject = GameObject.Find("Hand_Right");
//		handLeftObject = GameObject.FindGameObjectWithTag(Tags.handLeft);
		handLeftObject = GameObject.Find("Hand_Left");
		footRight = footRightObject.GetComponent<MemberControl>();
		footLeft = footLeftObject.GetComponent<MemberControl>();
		handRight = handRightObject.GetComponent<MemberControl>();
		handLeft = handLeftObject.GetComponent<MemberControl>();
		JoystickAssignation();

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

		footRight.canControl = true;
		footLeft.canControl = true;
		handLeft.canControl = true;
		handRight.canControl = true;

		MoveMember(footRightObject,footRight, hFootRight, vFootRight);
		MoveMember(footLeftObject,footLeft, hFootLeft, vFootLeft);
		MoveMember(handRightObject,handRight, hHandRight, vHandRight);
		MoveMember(handLeftObject,handLeft, hHandLeft, vHandLeft);
	}

	void MoveMember(GameObject member, MemberControl m , float h, float v)
	{
		m.anim.enabled = false;
		Vector3 movement = new Vector3(h,v,0)*Time.deltaTime;
		if(movement != Vector3.zero)
			m.anim.enabled = true;
//		Debug.Log (movement);
//		if(m.canControl)
//		{
			if(!gravityController.IsGravityOn)
			{
				member.rigidbody2D.AddForce(movement*gravitySpeed);
			}
			else
			{
				if(OnFloorCounter() != 0)// || !CanControlAll())
				{
					member.rigidbody2D.MovePosition(member.transform.position + movement*speed);
				}
//				else
//				{
//					m.canControl = false;
//				}
			}
//		}
	}

	void JoystickAssignation()
	{
		if(player1_keyboard)
		{
			rightLegHorizontal = InputController.rightLegHorizontalKey;
			rightLegVertical = InputController.rightLegVerticalKey;
			if(twoPlayer)
			{
				rightArmHorizontal = InputController.rightArmHorizontalKey;
				rightArmVertical = InputController.rightArmVerticalKey;
			}
		}
		else
		{
			rightLegHorizontal = InputController.rightLegHorizontal;
			rightLegVertical = InputController.rightLegVertical;
			if(twoPlayer)
			{
				rightArmHorizontal = InputController.rightArmHorizontalAlt;
				rightArmVertical = InputController.rightArmVerticalAlt;
			}
		}
		if(player2_keyboard)
		{
			leftLegHorizontal = InputController.leftLegHorizontalKey;
			leftLegVertical = InputController.leftLegVerticalKey;
			if(twoPlayer)
			{
				leftArmHorizontal = InputController.leftArmHorizontalKey;
				leftArmVertical = InputController.leftArmVerticalKey;
			}
		}
		else
		{
			leftLegHorizontal = InputController.leftLegHorizontal;
			leftLegVertical = InputController.leftLegVertical;
			if(twoPlayer)
			{
				leftArmHorizontal = InputController.leftArmHorizontalAlt;
				leftArmVertical = InputController.leftArmVerticalAlt;
			}
		}
		if(!twoPlayer)
		{
			if(player3_keyboard)
			{
				rightArmHorizontal = InputController.rightArmHorizontalKey;
				rightArmVertical = InputController.rightArmVerticalKey;
			}
			else
			{
				rightArmHorizontal = InputController.rightArmHorizontal;
				rightArmVertical = InputController.rightArmVertical;
			}
			if(player4_keyboard)
			{
				leftArmHorizontal = InputController.leftArmHorizontalKey;
				leftArmVertical = InputController.leftArmVerticalKey;
			}
			else
			{
				leftArmHorizontal = InputController.leftArmHorizontal;
				leftArmVertical = InputController.leftArmVertical;
			}
		}
	}

	int OnFloorCounter()
	{
		int onFloorCount = 0;
		if(footLeft.isOnFloor)
			onFloorCount++;
		if(footRight.isOnFloor)
			onFloorCount++;
		if(handRight.isOnFloor)
			onFloorCount++;
		if(handLeft.isOnFloor)
			onFloorCount++;
		return onFloorCount;
	}

	bool CanControlAll()
	{
		return footRight.canControl && footLeft.canControl && handRight.canControl && handLeft.canControl;
	}
}
