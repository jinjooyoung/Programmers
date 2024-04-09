using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Nine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //삼항 연산자 기본예제
        //삼항 연산자의 기본형태 [불 표현식] ? [참] : [거짓]
        string input = "-52273";        //입력을 받고
        int number2 = int.Parse(input); //int형으로 변환함

        Debug.Log(number2 > 0 ? "자연수입니다." : "자연수가 아닙니다.");
        //변환한 값이 0보다 크다 True일시 왼쪽 "자연수입니다"가 출력됨


        //응용예제
        Debug.Log("당신의 봄날은 안녕하신가요?");
        string line = "안녕합니다";

        if (line.Contains("안녕")) //line의 변수에 "안녕"이라는 문자열이 있는가?
        {
            Debug.Log("안녕하세요!");    //있다면 "안녕하세요!" 출력
        }
        else
        {
            Debug.Log("추운 겨울이 지나면 봄이 옵니다.");    //없다면 이거 출력
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
