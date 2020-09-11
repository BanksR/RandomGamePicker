using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class DiceRollingObject 
{

	public int RollADice(int sides)
	{
		int val = Mathf.CeilToInt(Random.value * sides);
		return val;
	}
}
