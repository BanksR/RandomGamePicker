using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour 

{

	ParticleSystem[] parts;

	// Use this for initialization
	void Awake () 
	{

        EventManager.OnClicked += Burst;
		parts = GetComponentsInChildren<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Burst()
	{
		foreach (ParticleSystem i in parts) 
		{
			i.Play ();
		}

	}
}
