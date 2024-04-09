using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Fifteen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string message = "안녕하세요";   //message 라는 문자형 변수에 안녕하세요 저장

        Debug.Log(message + "!");   //위에서 저장한 변수에 문자 !를 추가하여 출력함
        Debug.Log(message[0]);      //변수의 첫번째 글자를 출력
        Debug.Log(message[1]);      //변수의 두번째 글자를 출력
        Debug.Log(message[2]);      //변수의 세번째 글자를 출력

        Debug.Log("안녕하세요"[0]);      //안녕하세요 라는 문자열의 첫번째 글자를 출력
        Debug.Log("안녕하세요"[1]);      //안녕하세요 라는 문자열의 두번째 글자를 출력
        Debug.Log("안녕하세요"[2]);      //안녕하세요 라는 문자열의 세번째 글자를 출력

        //Debug.Log("string : " + sizeof(string));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
