using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four__One : MonoBehaviour
{
    // 프로그래밍의 이해 11주차 강의자료
    // 응용예제 4-1
    // 문자열 처리

    // Start is called before the first frame update
    void Start()
    {
        // 1. 대문자와 소문자화
        string input = "Potato Tomato";
        Debug.Log(input.ToUpper());
        Debug.Log(input.ToLower());
        Debug.Log(input);       // Potato Tomato 가 출력됨


        // 2. 문자열 자르기
        string input2 = "감자 고구마 토마토";
        string[] inputs = input2.Split(new char[] { ' ' });

        foreach (var item in inputs)
        {
            Debug.Log(item);
        }


        // 3. 문자열 양 옆의 공백 제거
        string input3 = " test        ";
        Debug.Log("::" + input3.Trim() + "::");


        // 4. 배열을 문자열로 변환
        string[] array = { "감자", "고구마", "토마토", "가지" };
        Debug.Log(string.Join(", ", array));
    }
}
