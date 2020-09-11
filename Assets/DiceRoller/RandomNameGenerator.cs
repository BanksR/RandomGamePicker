using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNameGenerator 
{
	List<string> firstName = new List<string>();
	List<string> surname = new List<string>();


	public string FirstName()
	{
		firstName.Add("Richard");
		firstName.Add("Chad");
		firstName.Add("Gordon");
		firstName.Add("Ian");
		firstName.Add("Neil");
		firstName.Add("Paul");
		firstName.Add("Brian");
		firstName.Add("Duncan");
		firstName.Add("Steve");
		firstName.Add("Blegg");
		firstName.Add("Glenn");
		firstName.Add("Stooge");
		firstName.Add("Grant");
		firstName.Add("Charles");
		firstName.Add("Plonger");
		firstName.Add("Flep");



		return firstName[Random.Range(0, firstName.Count - 1)];
	}

	public string Surname()
	{
		surname.Add("Blonks");
		surname.Add("Cheferson");
		surname.Add("Clanger");
		surname.Add("Smith");
		surname.Add("Jones");
		surname.Add("Singh");
		surname.Add("Chunk");
		surname.Add("Denk");
		surname.Add("Plonk");
		surname.Add("Richards");
		surname.Add("Banks");
		surname.Add("Plopperson");
		surname.Add("Dregg");
		surname.Add("Donk");

		return surname[Random.Range(0, surname.Count - 1)];

	}


}
