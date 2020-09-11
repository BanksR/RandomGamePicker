using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollerObject
{

	public List<string> students = new List<string>();
	public List<string> surnames = new List<string>();
	
	

	public int RollADice(int sides)
	{
		int rand = Mathf.CeilToInt(Random.Range(0f, 1f) * sides);

		return rand;
	}

	public string pickRandomStudentFirstName()
	{
		students.Add("Bob");
		students.Add("Steve");
		students.Add("Brian");
		students.Add("Carl");
		students.Add("Ernie");
		students.Add("Frank");
		students.Add("Gunther");
		students.Add("Ruprecht");
		students.Add("Bongo");
		students.Add("Charlie");
		students.Add("Maritzio");
		students.Add("Declan");
		students.Add("Roger");
		students.Add("Finkle");
		students.Add("Clunger");
		students.Add("Floop");
		students.Add("Clong");
		students.Add("Gurp");
		students.Add("Dreck");
		students.Add("Goop");
		students.Add("Phong");
		students.Add("Blinn");
		students.Add("Clive");

		return students[Random.Range(0, students.Count - 1)];
	}

	public string pickRandomStudentSecondName()
	{
		surnames.Add("Brown");
		surnames.Add("Smith");
		surnames.Add("Singh");
		surnames.Add("Bongerson");
		surnames.Add("Dunkley");
		surnames.Add("Frankenson");
		surnames.Add("Blinkley");
		surnames.Add("Gonger");
		surnames.Add("Derper");
		surnames.Add("Dooley");
		surnames.Add("Clanger");
		surnames.Add("Willey");
		surnames.Add("Ploppings");
		surnames.Add("Blurger");
		surnames.Add("Klopp");
		surnames.Add("Goop");
		surnames.Add("Flonge");
		surnames.Add("Flange");
		surnames.Add("Dunkey");
		surnames.Add("Derp");

		return surnames[Random.Range(0, surnames.Count - 1)];
	}
}
