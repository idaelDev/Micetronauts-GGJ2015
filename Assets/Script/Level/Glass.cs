using UnityEngine;
using System.Collections;

public class Glass : MonoBehaviour {

	public float minVelocityToBreak = 5f;
	public Sprite glassBroken2;
	public Sprite glassBroken3;
    public AudioClip glassSound2;
    public AudioClip glassSound3;
	public GameObject glassExplode;
	public GravityOnObject[] gravityObject;

	private int breakCount = 0;
	private SpriteRenderer sr;
    private AudioSource audio;

	void Awake()
	{
		sr = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
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
            audio.Play();
			sr.sprite = glassBroken2;
		}
		if(breakCount == 1)
		{
            audio.clip = glassSound2;
            audio.Play();
			sr.sprite = glassBroken3 ;
		}
		if(breakCount == 2)
		{
			Instantiate(glassExplode, transform.position, Quaternion.identity);
            audio.clip = glassSound3;
            audio.Play();
			for(int i = 0; i<gravityObject.Length; i++)
			{
				gravityObject[i].SwitchGravity();
			}
			Destroy(gameObject);
		}
		breakCount++;
	}
	
}
