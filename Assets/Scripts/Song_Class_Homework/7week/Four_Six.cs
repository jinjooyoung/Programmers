using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Six : MonoBehaviour
{
    //기본예제 4-6 한글 전부 출력하기

    // Start is called before the first frame update
    void Start()
    {
        for (int m = '가';  m <= '힣'; m++) 
        {
            Debug.Log((char)m);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
