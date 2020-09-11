using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StudnetPicker : MonoBehaviour 
{

    public TextAsset listofStudentNames;
    public string[] splitNames;

    private Text displayText;

    public List<string> student;

    public float popTime = 1f;


	void Awake()
    {
        EventManager.OnClicked += PickName;
        displayText = GetComponent<Text>();
        splitNames = listofStudentNames.text.Split('\n');

        foreach(string s in splitNames)
        {
            student.Add(s);
        }

        //PickName();
        displayText.text = "";



    }

    public void PickName()
    {
        if (student.Count != 0)
        {
            int rand = Random.Range(0, student.Count);

            displayText.text = student[rand];
            StartCoroutine(TextPop());

            RemoveName(rand);
        }
        else
        {
            displayText.text = "";
        }

        
    }

    public void RemoveName(int i)
    {
        student.RemoveAt(i);
    }

    
    
    IEnumerator TextPop()
    {
        float t = 0;
        transform.localScale = Vector3.zero;
        

        while (t < popTime)
        {
            t += Time.fixedDeltaTime;
            transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t / popTime);
            yield return new WaitForFixedUpdate();
        }

        yield return null;

    }
}
