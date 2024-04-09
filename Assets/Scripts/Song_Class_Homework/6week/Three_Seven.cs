using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Seven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if 조건문
        int inputNumber = 2021;

        if (inputNumber % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
        else
        {
            Debug.Log("홀수입니다.");
        }

        //switch 조건문
        switch (inputNumber % 2)
        {
            case 0:
                Debug.Log("짝수입니다.");
                break;
            case 1:
                Debug.Log("홀수입니다.");
                break;

                //break 키워드 : switch 조건문 또는 반복문을 빠져나갈 때 사용
                //switch 조건문 괄호 안에는 비교할 값 입력, 입력값을 기준으로 특정 코드 실행
                //입력한 표현식과 case 키워드 옆의 표현식 같으면, case 키워드 바로 다음 문장 차례로 실행
        }
        //break가 없으면 조건에 맞지 않아도 출력될 수 있음
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
