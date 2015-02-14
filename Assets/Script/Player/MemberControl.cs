using UnityEngine;
using System.Collections;

public class MemberControl : MonoBehaviour 
{
	public bool canControl = true;
	public bool isOnFloor = false;
	
    public SpriteRenderer anim;
    private AudioSource audio;

	private float height = 0;
	private float maxUp;


    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

//	void FixedUpdate()
//	{
////		if(!canControl)
////		{
////			rigidbody2D.AddForce(new Vector2(0,-15));
////		}
//	}

    public void Activate(bool active)
    {
        if(active)
        {
            audio.mute = false;
            anim.enabled = true;
        }
        else
        {
            audio.mute = true;
            anim.enabled = false;
        }
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag != Tags.body)
		{
			isOnFloor = true;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.tag != Tags.body)
		{
			isOnFloor = false;
		}
	}
}
