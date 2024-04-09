using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 10;
        Debug.Log(number);      //변수 출력
        Debug.Log(number++);    //일단 변수를 출력하고 1을 더함 > 10출력
        Debug.Log(number--);    //일단 변수를 출력하고 1을 빼줌 > 11출력
        Debug.Log(number);      //변수 출력 > 위에서 1을 빼줬기 때문에 10 출력
        
        Debug.Log(number);      //변수 출력
        Debug.Log(++number);    //1을 더한 변수를 출력함 > 11
        Debug.Log(--number);    //1을 뺀 변수를 출력함 > 10
        Debug.Log(number);      //변수 출력 > 10

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
