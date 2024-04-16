using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_One : MonoBehaviour
{
    //기본예제 4-1

    // Start is called before the first frame update
    void Start()
    {
        int[] intArray = { 52, 273, 32, 65, 103 };
        //배열 생성 자료형[] 이름 = [자료, 자료 ...];

        intArray[0] = 0;
        //배열의 요소를 변경합니다
        //배열은 첫번째가 0이고 0, 1, 2... 순서임

        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);
        //요소 출력. 배열의 첫번째인 52를 9으로 변경하였으니 52가 아닌 0이 출력될것임.

        Debug.Log(intArray.Length);
        //배열의 길이를 출력 (5)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
