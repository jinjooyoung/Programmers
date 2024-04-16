using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Three : MonoBehaviour
{
    //기본예제 4-3 반복문 이용하기

    // Start is called before the first frame update
    void Start()
    {
        int j = 0;
        int[] intArray3 = { 52, 273, 32, 65, 103 };
        //변수 선언

        while (j < intArray3.Length) //반복 수행
        {
            Debug.Log(j + "번째 출력" + intArray3[j]);
            //출력

            j++;
            //탈출을 위해 변수를 더함
            //이게 없으면 무한 루프에 걸려 컴퓨터가 사망함
        }

        //j가 0으로 시작하여 intArray3.Length인 5보다 작으므로 While문이 실행. 첫번째 요소를 출력.
        //출력한 뒤 j가 1이 증가하고 1은 intArray3.Length인 5보다 작으므로 While문이 실행. 두번째 요소를 출력.
        //반복하다가 j가 증가하여 5가 된다면 intArray3.Length인 5보다 작지 않으므로 더이상 반복하지 않음
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
