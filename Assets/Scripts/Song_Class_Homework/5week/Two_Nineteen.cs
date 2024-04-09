using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Nineteen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //증감 연산자 사용 변수 앞과 뒤에 ++, --를 붙여 만듦
        int number = 10;
        number++;       //이 라인이 끝나면서 넘버에 1을 더해줌
        Debug.Log(number);      //1이 더해진 11이 출력됨
        number--;       //이 라인이 끝나면서 넘버에 1을 빼줌
        Debug.Log(number);      //1이 빠진 10이 출력됨
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
