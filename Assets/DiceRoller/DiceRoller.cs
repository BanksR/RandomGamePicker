using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DiceRoller : MonoBehaviour
{

	// Get a reference to the UI display text
	public Text DiceRollTextDisplay;

	//[Range(1, 100)] public int Range;


	void Update()
	{
		if (Input.anyKeyDown)
		{
			Roll();
		}
	}

	// This function is responsible for calculating a random number
	// and setting the display text appropriately
	public void Roll()
	{
		// Here we create a random integer
		//Random.InitState(Random.Range(0, 1000000));
		int rand = Mathf.CeilToInt(Random.Range(0f, 1f) * 6);
		
		// Here we plug in the random value into our display text.
		// We need to convert the integer number into a string to display correctly.
		// We can use the helpful ToString() function for this
		
		DiceRollTextDisplay.text = rand.ToString();

	}
}
