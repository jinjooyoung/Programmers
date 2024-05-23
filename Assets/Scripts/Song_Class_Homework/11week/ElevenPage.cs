using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevenPage : MonoBehaviour
{
    // 프로그래밍의 이해 11주차 강의자료
    // 변형예제 4-14
    // Continue 키워드 없이 같은 결과가 출력되도록

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
