using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageThirteen : MonoBehaviour
{
    // 12주차
    // Random 클래스
    // 변형예제 8-1 (0~ 10.0까지의 랜덤 실수 5개)

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(random.NextDouble() * 10);
        }

        // NextDouble() 메서드는 0.0 ~ 1.0 사이의 임의의 수를 반환함
        // 0.0 ~ 10.0까지의 랜덤 실수 5개가 필요하므로 10을 곱해서 출력함
    }
}
