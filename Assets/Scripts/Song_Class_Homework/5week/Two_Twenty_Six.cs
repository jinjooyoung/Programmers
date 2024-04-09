using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Six : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //자동 자료형 변환

        /*기존 자료형 --> 자동 변환되는 자료형
        int             long, float, double
        long            float, double
        char            int, long, float, double
        float           double*/

        //int 자료형의 숫자를 생성
        int intNumber = 2147483647;

        //int 자료형을 long 자료형으로 자동 변환
        long intToLong = intNumber;
        Debug.Log(intToLong);

        //int 자료형을 double 자료형으로 자동 변환
        double intToDouble = intNumber;
        Debug.Log(intToDouble);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
