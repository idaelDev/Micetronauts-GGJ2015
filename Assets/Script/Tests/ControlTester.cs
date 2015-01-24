using UnityEngine;
using System.Collections;

public class ControlTester : MonoBehaviour {

	public float hFootRightKey;
	public float vFootRightKey;
	public float hFootLeftKey;
	public float vFootLeftKey;
	public float hHandRightKey;
	public float vHandRightKey;
	public float hHandLeftKey;
	public float vHandLeftKey;

	public float hFootRight;
	public float vFootRight;
	public float hFootLeft;
	public float vFootLeft;
	public float hHandRight;
	public float vHandRight;
	public float hHandLeft;
	public float vHandLeft;

	public float hHandRightAlt;
	public float vHandRightAlt;
	public float hHandLeftAlt;
	public float vHandLeftAlt;
	
	void Update()
	{
		 hFootRightKey = Input.GetAxis(InputController.rightLegHorizontalKey);
		 vFootRightKey = Input.GetAxis(InputController.rightLegVerticalKey);

		 hFootLeftKey = Input.GetAxis(InputController.leftLegHorizontalKey);;
		 vFootLeftKey = Input.GetAxis(InputController.leftLegVerticalKey);;

		 hHandRightKey = Input.GetAxis(InputController.rightArmHorizontalKey);
		 vHandRightKey = Input.GetAxis(InputController.rightArmVerticalKey);

		 hHandLeftKey = Input.GetAxis(InputController.leftArmHorizontalKey);
		 vHandLeftKey = Input.GetAxis(InputController.leftArmVerticalKey);
		
		 hFootRight = Input.GetAxis(InputController.rightLegHorizontal);
		 vFootRight = Input.GetAxis(InputController.rightLegVertical);

		 hFootLeft = Input.GetAxis(InputController.leftLegHorizontal);;
		 vFootLeft = Input.GetAxis(InputController.leftLegVertical);;

		 hHandRight = Input.GetAxis(InputController.rightArmHorizontal);
		 vHandRight = Input.GetAxis(InputController.rightArmVertical);

		 hHandLeft = Input.GetAxis(InputController.leftArmHorizontal);
		 vHandLeft = Input.GetAxis(InputController.leftArmVertical);
		
		 hHandRightAlt = Input.GetAxis(InputController.rightArmHorizontalAlt);
		 vHandRightAlt = Input.GetAxis(InputController.rightArmVerticalAlt);

		 hHandLeftAlt = Input.GetAxis(InputController.leftArmHorizontalAlt);
		 vHandLeftAlt = Input.GetAxis(InputController.leftArmVerticalAlt);
	}
}
