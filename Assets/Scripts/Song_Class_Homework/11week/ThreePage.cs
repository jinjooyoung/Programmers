using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePage : MonoBehaviour
{
    // 프로그래밍의 이해 11주차 강의자료
    // 3페이지
    // Break 키워드

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;

        while (true)
        {
            sum += 10;
            Debug.Log(sum);
            if (sum % 100 == 0 )
            {
                break;
            }
        }
    }
}
