using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{

	public Actor playerActor, enemyActor;
	private bool turn = true;
	public bool inBattle = true;


	private void Update()
	{
		if (Input.anyKeyDown && turn && inBattle)
		{
			
			ResolveAttact(playerActor, enemyActor);
		}
		else if(Input.anyKeyDown && !turn && inBattle)
		{
			
			ResolveAttact(enemyActor, playerActor);
		}
	}

	public void ResolveAttact(Actor attacker, Actor defender)
	{
		int damage = new DiceRollerObject().RollADice(attacker.strength);
		
		if (defender.hitPoints > 0 && attacker.isAlive)
		{
			defender.TakeDamage(damage);
			if (defender.isAlive)
			{
				Debug.Log(attacker._name + " hits "+ defender._name + " for " + damage +". "+defender._name+ " has "+defender.hitPoints + " remaining");
				turn = !turn;
			}
			else
			{
				Debug.Log(attacker._name + " hits for " +damage+ " and kills " +defender._name + "!");
			
				EndBattle(defender);
			}

		}
		
	}

	void EndBattle(Actor loser)
	{
		inBattle = false;
		Debug.Log(loser._name +" loses!");
	}
}
