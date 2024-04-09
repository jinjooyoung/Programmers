using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int inputNumber = 2021;

        if (inputNumber % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
        else
        {
            Debug.Log("홀수입니다.");
        }

        //if의 조건에 맞지 않으면 else가 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
