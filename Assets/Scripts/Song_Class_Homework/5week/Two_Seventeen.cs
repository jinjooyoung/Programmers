using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Seventeen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //복합 대입 연산자
        int output = 0;
        output += 52;       //0에 52를 더한값을 output에 저장
        output += 273;      //52에 273를 더한값을 output에 저장
        output += 103;      //325에 103를 더한값을 output에 저장

        Debug.Log(output);      //가장 마지막에 저장한 output값을 출력

        /*+= 덧셈 후 대입 연산자
        -= 뺄셈 후 대인 연산자
        *= 곱셈 후 대입 연산자
        /= 나눗셈 후 대입 연산자*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
