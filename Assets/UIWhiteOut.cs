using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWhiteOut : MonoBehaviour 
{

    Animator anim;

    void Awake()
    {
        EventManager.OnClicked += WhiteOut;
        anim = GetComponent<Animator>();

    }

    private void WhiteOut()
    {

        anim.SetTrigger("Fade");
    }
	
}
