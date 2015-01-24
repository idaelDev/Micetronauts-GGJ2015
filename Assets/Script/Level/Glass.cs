using UnityEngine;
using System.Collections;

public class Glass : MonoBehaviour {

	public float minVelocityToBreak = 5f;
	public Sprite glassBroken2;
	public Sprite glassBroken3;
	public GameObject glassExplode;

	private int breakCount = 0;
	private SpriteRenderer sr;

	void Awake()
	{
		sr = GetComponent<SpriteRenderer>();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			if(other.gameObject.rigidbody2D.velocity.magnitude >= minVelocityToBreak)
			{
				SetSprite();
			}
		}
	}

	void SetSprite()
	{
		if(breakCount == 0)
		{
			sr.sprite = glassBroken2;
		}
		if(breakCount == 1)
		{
			sr.sprite = glassBroken3 ;
		}
		if(breakCount == 2)
		{
			Instantiate(glassExplode, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
		breakCount++;
	}
	
}
