using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPDiceRoller
{

	public int Roll(int sides)
	{
		int rand = Mathf.CeilToInt((Random.Range(0f, 1f) * sides));
		return rand;
	}
}
