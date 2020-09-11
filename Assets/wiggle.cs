using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wiggle : MonoBehaviour 
{

	public float noiseMulti = 1f;
	public float freq = 1f;

	Text textToWobble;
	// Use this for initialization
	void Awake () 
	{
		textToWobble = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float noiseY = Mathf.PerlinNoise (0f, Time.time) * noiseMulti - 0.5f;
		float noiseX = Mathf.PerlinNoise (Time.time, 0f) * noiseMulti - 0.5f;
		Vector3 pos = new Vector3 (transform.position.x+ noiseX, transform.position.y + noiseY, transform.position.z);

		transform.position = pos;
		
	}
}
