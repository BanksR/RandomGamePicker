using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class GenerateRandomName : MonoBehaviour
{

	private string Rname = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.anyKeyDown)
		{
			Rname = new RandomNameGenerator().FirstName() + " " + new RandomNameGenerator().Surname();
			Debug.Log(Rname);
		}
	}
}
