using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Eight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int inputNumber = 4;

        Debug.Log("이번 달은 몇 월인가요: " + inputNumber);
        switch (inputNumber)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("겨울 입니다.");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("봄 입니다.");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("여름 입니다.");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("가을 입니다.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
