using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Seven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //다른 자료형을 숫자로 변환

        /*문자열을 숫자로 변환하는 매서드
        매서드 이름      설명
        int.Parse()     다른 자료형을 int 자료형으로 변경
        long.Parse()    다른 자료형을 long 자료형으로 변경
        float.Parse()   다른 자료형을 float 자료형으로 변경
        double.Parse()  다른 자료형을 double 자료형으로 변경*/

        Debug.Log(int.Parse("52"));
        Debug.Log(long.Parse("273"));
        Debug.Log(float.Parse("52.273"));
        Debug.Log(double.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());       //해당 변수의 자료형을 추출
        Debug.Log(long.Parse("273").GetType());
        Debug.Log(float.Parse("52.273").GetType());
        Debug.Log(double.Parse("103.32").GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
