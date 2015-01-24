﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public bool twoPlayer = false;

	public bool player1_keyboard = false;
	public bool player2_keyboard = false;
	public bool player3_keyboard = false;
	public bool player4_keyboard = false;

	public float speed = 5f;

	private string rightLegHorizontal;
	private string rightLegVertical;

	private string leftLegHorizontal;
	private string leftLegVertical;

	private string rightArmHorizontal;
	private string rightArmVertical;

	private string leftArmHorizontal;
	private string leftArmVertical;

	private GameObject footRightObject;
	private GameObject footLeftObject;
	private GameObject handRightObject;
	private GameObject handLeftObject;
	private Foot footRight;
	private Foot footLeft;
	private Hand handRight;
	private Hand handLeft;

	void Awake()
	{
		footRightObject = GameObject.FindGameObjectWithTag(Tags.footRight);
		footLeftObject = GameObject.FindGameObjectWithTag(Tags.footLeft);
		handRightObject = GameObject.FindGameObjectWithTag(Tags.handRight);
		handLeftObject = GameObject.FindGameObjectWithTag(Tags.handLeft);
		footRight = footRightObject.GetComponent<Foot>();
		footLeft = footLeftObject.GetComponent<Foot>();
		handRight = handRightObject.GetComponent<Hand>();
		handLeft = handLeftObject.GetComponent<Hand>();
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

		MoveMember(footRightObject, hFootRight, vFootRight);
		MoveMember(footLeftObject, hFootLeft, vFootLeft);
		MoveMember(handRightObject, hHandRight, vHandRight);
		MoveMember(handLeftObject, hHandLeft, vHandLeft);
	}

	void MoveMember(GameObject member, float h, float v)
	{
		if(OnFloorCounter() > 1)
		{
			Vector3 movement = new Vector3(h,v,0)*speed*Time.deltaTime;
			member.rigidbody2D.MovePosition(member.transform.position + movement);
		}
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
}