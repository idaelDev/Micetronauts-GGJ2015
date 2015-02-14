using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
	public Activable activable;
	public string tag;
	public bool isActivated = false;
	public Color validatingColor;
	private Color col;
    private AudioSource audio;

	void Awake()
	{
        audio = GetComponent<AudioSource>();
		col = gameObject.renderer.material.color;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == tag)
		{
			isActivated = true;
			gameObject.renderer.material.color = validatingColor;
			if(activable !=  null)
				activable.Activate();
            if(audio != null)
            {
                if (!audio.isPlaying)
                    audio.Play();
            }
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.foot || other.gameObject.tag == Tags.hand)
		{
			isActivated = false;
			gameObject.renderer.material.color = col;
		}
	}
}
