﻿using UnityEngine;
using System.Collections;

public class MultipleButton : MonoBehaviour {

	public Activable activable;

	public Button[] buttons;
	private bool done;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if(!done)
		{
			bool ok = true;
			for(int i=0; i<buttons.Length; i++)
			{
				if(buttons[i].isActivated == false)
				{
					ok = false;
					break;
				}
			}
			if(ok)
			{
				activable.Activate();
				done = true;
			}
		}
	}
}
