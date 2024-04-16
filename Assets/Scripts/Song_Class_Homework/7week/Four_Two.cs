using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Two : MonoBehaviour
{
    //기본예제 4-2 원하는 크기의 배열 생성 

    // Start is called before the first frame update
    void Start()
    {
        int[] intArray2 = new int[100];
        //빈칸의 배열을 100개 생성

        Debug.Log(intArray2[0]);
        Debug.Log(intArray2[99]);
        //요소를 출력
        //숫자 자료형의 빈칸이기때문에 둘 다 0이 출력될것임.

        //Debug.Log(intArray2[100]); 요소를 100개 만들어도 0부터 갯수를 세기 때문에 intArray2[100]은 존재하지 않음 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
