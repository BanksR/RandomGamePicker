using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void ClickAction();
    public delegate void ReRoll();
    public static event ClickAction OnClicked;
    public static event ReRoll ReRollEvent;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(OnClicked != null)
            {
                OnClicked();
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            if(ReRollEvent != null)
            {
                ReRollEvent();
            }
        }
    }
}
