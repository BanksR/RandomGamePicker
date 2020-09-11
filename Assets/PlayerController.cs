using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private DiceRollerObject _diceRollerObject;

	public Text[] uiTexts;
	public Text nameText;
	public Text hiScoreText;
	
	[Range(1, 20)]
	public int SidedDice;

	public string PlayerName;
	private int _diceTotal = 0;
	private int currentHighScore = 0;

	private void Awake()
	{
		
	}


	void Update()
	{
		if (Input.anyKeyDown)
		{
			CalculateDiceRoll();
			GenerateName();
		}
	}

	private void CalculateDiceRoll()
	{
		_diceTotal = 0;
		foreach (var t in uiTexts)
		{
			int val = new DiceRollerObject().RollADice(SidedDice);
			_diceTotal += val;
			t.text = val.ToString();
			if (val < (SidedDice / 2))
			{
				t.color = Color.red;
			}
			else if (val == SidedDice)
			{
				t.color = Color.yellow;
			}
			else
			{
				t.color = Color.white;
			}
		}
	}

	private void GenerateName()
	{
		string firstName = new DiceRollerObject().pickRandomStudentFirstName();
		string lastName = new DiceRollerObject().pickRandomStudentSecondName();

		nameText.text = firstName + " " + lastName + " scores: " + _diceTotal;
		CalculateBestScore(firstName, _diceTotal);
	}

	private void CalculateBestScore(string name, int score)
	{
		if (score > currentHighScore)
		{
			currentHighScore = score;
			hiScoreText.text = "Highest Score is: " + name + " with: " + score + " points";
		}
	}
}
