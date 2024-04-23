using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Eight : MonoBehaviour
{
    // 프로그래밍의 이해 10주차 강의자료
    // 기본예제 4-8
    // 역 for 반복문

    // Start is called before the first frame update
    void Start()
    {
        // 배열 생성
        int[] intArray4 = { 1, 2, 3, 4, 5, 6 };     // Length 는 6이고 5번까지 있음

        // 요소의 길이 출력
        for ( int i = intArray4.Length - 1; i >= 0; i-- )   // i가 배열 길이 6 -1인 5부터 시작 하므로 5번호수인 6부터 출력
        {
            Debug.Log(intArray4[i] );   // 출력하고 i가 1 줄어들어 4번호수인 5가 출력 -> 0번호수인 1까지 차례대로 출력
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
