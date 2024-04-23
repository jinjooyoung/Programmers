using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Twelve : MonoBehaviour
{
    // 프로그래밍의 이해 10주차 강의자료
    // 변형예제 4-12
    // 중첩 반복문 - 별 피라미드 (2)

    // Start is called before the first frame update
    void Start()
    {
        string count = "";
        string stars = "";
        for (int i = 0; i < 10; i++)
        {
            count = "";     // 중간 for문이 끝나고 공백을 초기화
            for (int j = 0; j < 9-i; j++) //0~9 10  0 ~ 8 9
            {
                count += " "; // 9번 반복하여 공백을 9로 생성      // 2번째 반복 때 i가 1이 되었으므로 8번 반복하여 공백을 8로 생성 -> 공백이 0이 될 때까지 반복
            }
            stars += "*";                   //별을 하나 추가함
            Debug.Log(count + stars);      // 공백 뒤에 현재 별의 갯수를 붙여서 출력함      
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
