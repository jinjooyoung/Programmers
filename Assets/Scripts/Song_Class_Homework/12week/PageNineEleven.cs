using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageNineEleven : MonoBehaviour
{
    // 12주차
    // Random 클래스
    // 클래스를 활용한 임의의 정수, 임의의 실수 생성방법

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        random.Next();          // 음수가 아닌 임의의 정수 반환
        random.Next(100);       // 음수가 아니고 100 미만인 임의의 정수 반환 (0~99)
        random.Next(10, 100);   // 10 <= x < 100 인 임의의 정수 반환 (10~99)

        // Random 클래스의 정의를 인스턴스 random에서 불러오고
        // 그 아래줄의 random에 dot(.)을 붙여서 Random클래스에 있는 Next를 불러옴
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
