using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour 
{
    AudioSource audioSource;

	// Use this for initialization
	void Start () 
    {
        audioSource = GetComponent<AudioSource>();
        EventManager.OnClicked += PlayMe;
		
	}
	
    private void PlayMe()
    {
        float pickRand = Random.Range(.8f, 1.1f);

        audioSource.pitch = pickRand;
        audioSource.PlayOneShot(audioSource.clip);


    }
}
