using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Actor")]

public class Actor : ScriptableObject
{

	public int hitPoints;
	public string _name;
	public int strength;
	public int defense;

	public bool isAlive = true;

	public void TakeDamage(int incomingDmg)
	{
		int damage = hitPoints - incomingDmg;
		if (damage > 0)
		{
			hitPoints -= incomingDmg;
		}
		else
		{
			isAlive = false;
		}
	}


}
