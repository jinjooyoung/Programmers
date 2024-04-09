using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_One : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int inputNumber = 2022;

        if (inputNumber % 2 == 0)       //2로 나눈 나머지가 0일때
        {
            Debug.Log("짝수입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
