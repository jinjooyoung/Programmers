using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Five : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //long 자료형을 int 자료형으로 변환
        long longNumber = 2147483647L + 2147483647L;
        int longToInt = (int) longNumber;
        Debug.Log(longToInt);       //long타입을 int타입으로 변경하면서 오버플로우

        //double 자료형을 int 자료형으로 변환
        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;    //doubleNumber에 저장된 값을 int로 바꾸어 doubleToInt에 저장 (doubleNumber 자체의 값이 변하는 것은 아님)
        Debug.Log(doubleToInt);     //int는 소수점이 없으므로 52 출력
        Debug.Log(doubleNumber);    //doubleNumber값이 바뀐건 아니므로 처음과 같이 52.27310332출력

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
