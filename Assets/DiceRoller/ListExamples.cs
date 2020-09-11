using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExamples : MonoBehaviour 

{
	// Here we initialise a new List called nameList
	List<string> nameList = new List<string>();

	private void Awake()
	{
		//Using the Add() function we can 'add'
		//string data to it
		nameList.Add("Richard");
	}
}
