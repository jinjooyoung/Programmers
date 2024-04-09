using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Four : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //강제 자료형 변환에 따른 데이터 손실 예
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int) longNumber;   //longNumber가 int가 담을 수 없을 정도로 큰 값이므로
        Debug.Log(intNumber);       //출력하면 오버플로우가 발생하여 값이 이상하게 출력됨

        //강제 자료형 변환에 따른 데이터 손실 발생하지 않는 예
        long longNumber2 = 52273;
        int intNumber2 = (int) longNumber2;     //longNumber2가 int가 담을 수 있는 정도의 작은 값이므로
        Debug.Log(intNumber2);      //출력하면 제대로 52273이 출력됨
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
