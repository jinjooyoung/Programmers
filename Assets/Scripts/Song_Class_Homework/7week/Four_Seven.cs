using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Four_Seven : MonoBehaviour
{
    //변형예제 4-7 2의 10승을 for문을 사용하여 계산하기

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        int m = 1;
        for (int i = 1; i <= 10; i++)
        {
            m *= 2;
            Debug.Log("2의 " + i + "승은 " + m);
            sum += m;
        }

        Debug.Log("모두 합산하면 " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
