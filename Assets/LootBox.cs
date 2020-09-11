using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBox : MonoBehaviour
{
	[Range(2, 100)] public int DiceSides;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.anyKeyDown)
		{
			int x = new OOPDiceRoller().Roll(DiceSides);
			Debug.Log("You have rolled a " + x);
		}
	}
}
