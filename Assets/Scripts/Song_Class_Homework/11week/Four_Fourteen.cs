using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Fourteen : MonoBehaviour
{
    // 프로그래밍의 이해 11주차 강의자료
    // 기본예제 4-14
    // Continue 키워드

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;       // 컨티뉴를 만나면 아래 코드를 생략하고 위의 반복으로 돌아감
            }
            Debug.Log(i);
        }
    }
}
// 2로 나누었을 때 0. 즉 짝수일 때 컨티뉴가 실행되므로
// 콘솔창에는 홀수만 출력될것임 (1, 3, 5, 7, 9)