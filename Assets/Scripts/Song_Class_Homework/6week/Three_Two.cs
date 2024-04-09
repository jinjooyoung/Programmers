using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Three_Two : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DateTime.Now.Year);
        Debug.Log(DateTime.Now.Month);
        Debug.Log(DateTime.Now.Day);
        Debug.Log(DateTime.Now.Hour);
        Debug.Log(DateTime.Now.Minute);
        Debug.Log(DateTime.Now.Second);

        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("오전입니다.");
        }

        if (DateTime.Now.Hour > 12)
        {
            Debug.Log("오후입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
