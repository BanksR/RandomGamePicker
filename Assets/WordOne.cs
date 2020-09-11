using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordOne : MonoBehaviour 
{
    public TextAsset word01;
    private Text displayText;
    private string[] splitWords;
    
    
    Queue<string> stringQueue = new Queue<string>();
    


	// Use this for initialization
	void Awake () 
    {
        EventManager.OnClicked += NewWord;

        EventManager.ReRollEvent += NewWord;
        displayText = GetComponent<Text>();
        splitWords = word01.text.Split('\n');

        NewWord();
        
        

        foreach (string studentName in splitWords)
        {
            stringQueue.Enqueue(studentName);
	        
        }

	    Debug.Log("Queue length: " + stringQueue.Count);

;	}


	
	public void NewWord()
	{
		string str = "";
		
		if (stringQueue.Count != 0)
		{
			str = stringQueue.Dequeue();
			
		}

		displayText.text = str;
		
	}

	
}
