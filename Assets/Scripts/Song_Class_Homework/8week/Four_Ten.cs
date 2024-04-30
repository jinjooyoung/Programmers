using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Ten : MonoBehaviour
{
    // 프로그래밍의 이해 10주차 강의자료
    // 기본예제 4-10
    // foreach 반복문과 var키워드

    // Start is called before the first frame update
    void Start()
    {
        // 변수를 선언 합니다.
        string[] array = { "사과", "배", "포도", "딸기", "바나나" };

        // 반복을 수행합니다.
        // foreach (string item in array)
        foreach (var item in array)
        {
            //출력합니다.
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
