using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollADice : MonoBehaviour
{
	[Range(0,20)]
	public int sidedDice = 6;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.anyKeyDown)
		{
			int rand = new DiceRollingObject().RollADice(sidedDice);
			string fn = new DiceRollerObject().pickRandomStudentFirstName();
			string ln = new DiceRollerObject().pickRandomStudentSecondName();
			Debug.Log(fn + " " + ln + " rolled a "+ rand);
		}

	}
}
