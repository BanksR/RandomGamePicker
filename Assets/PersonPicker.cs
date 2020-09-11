using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonPicker : MonoBehaviour 
{
	//Generate a list of names

	//when space bar is pressed, pick one at random, remove from list

	//display name in a new list in a grid

	List<string> nameList = new List<string>();
	List<string> Results = new List<string> ();

	
	
	public Text displayName;
	public Text finalList;

	[Space] public AudioClip[] clips;
	private AudioSource _aud;

	private int listPos = 0;
	private ParticleController partsControl;
	private bool canInput = true;


	// Use this for initialization
	void Awake () 
	{
		nameList.Add ("Imaania");
		nameList.Add ("Alexia");
		nameList.Add ("Joseph");
		nameList.Add ("Edward");
		nameList.Add ("Bailey");
		nameList.Add ("Benson");
		nameList.Add ("Luke");
		nameList.Add ("Scott");
		nameList.Add ("Bradley");
		nameList.Add ("Alex");
		nameList.Add ("Ryan");
		nameList.Add ("Connor");
		nameList.Add ("Dan");


		_aud = GetComponent<AudioSource>();
		partsControl = GameObject.Find ("ParticleBoom").GetComponent<ParticleController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canInput) 
		{
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				string selectedName = PickAName ();

				canInput = false;
				StartCoroutine (Reveal (selectedName));
				//DisplayName (selectedName);
			}
			
		}

		
	}

	public string PickAName()
	{
		string randomName;

		if (nameList.Count != 0) {
			int randIndex = Random.Range (0, nameList.Count);

			randomName = nameList [randIndex];
			nameList.RemoveAt (randIndex);
			return randomName;
		} else 
		{
			return "!!!";
		}

	}

	public void DisplayName (string nameToDisplay)
	{
		canInput = false;
		displayName.color = Color.white;
		displayName.text = nameToDisplay;
		MoveToListPos (nameToDisplay);
		StartCoroutine (FadeOutText ());
		canInput = true;
	}

	void MoveToListPos (string nameToMove)
	{
		listPos++;
		//append names to final list
		finalList.text += listPos+". "+nameToMove+"\n";


	}

	public IEnumerator Reveal(string nameToReveal)
	{
		
		//Play Particles
		partsControl.Burst();
		yield return new WaitForSeconds(1f);
		_aud.PlayOneShot(clips[Random.Range(0, clips.Length-1)]);
		DisplayName (nameToReveal);


	}

	public IEnumerator FadeOutText ()
	{
		
		float fadVal = 1f;

		yield return new WaitForSeconds(3);

		while (fadVal > 0f)
		{
			fadVal -= Time.deltaTime;

			displayName.color = new Color(1f,1f,1f, fadVal);
			yield return new WaitForEndOfFrame();
		}


		yield return null;


	}
}

