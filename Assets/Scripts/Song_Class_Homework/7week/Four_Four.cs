using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Four : MonoBehaviour
{
    //기본예제 4-4 do while 반복문 활용하기

    // Start is called before the first frame update
    void Start()
    {
        //while 반복문과 형태는 비슷하지만 조건비교 부분이 마지막에 위치함.

        int k = 0;
        //변수 선언

        do
        {
            Debug.Log(k + ") 한번은 반드시 출력됨.");
            ++k;
        }
        while (k < 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
