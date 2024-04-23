using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Eleven : MonoBehaviour
{
    // 프로그래밍의 이해 10주차 강의자료
    // 기본예제 4-11
    // 중첩 반복문 - 별 피라미드 (1)

    // Start is called before the first frame update
    void Start()
    {
        string stars;
        for (int n = 0; n < 10; n++)
        {
            stars = "";
            for (int o = 0; o < n+1; o++)
            {
                stars += "*";
            }
            Debug.Log(stars);
        }

        /*string stars = "";
        for (int n = 0; n < 10; n++)
        {
            stars += "*";
            Debug.Log(stars);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
