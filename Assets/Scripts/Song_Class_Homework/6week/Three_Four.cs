using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Four : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("오전입니다.");
        }

        else if (DateTime.Now.Hour > 12)
        {
            Debug.Log("오후입니다.");
        }
        //else if 는 if의 조건에 맞지 않는 상황에서의 if문
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
