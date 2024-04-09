using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Six : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("아침 먹을 시간입니다.");
        }
        else if (DateTime.Now.Hour < 15)
        {
            Debug.Log("점심 먹을 시간입니다.");
        }
        else
        {
            Debug.Log("저녁 먹을 시간입니다.");
        }
        //기본예제 3-5와 거의 비슷
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
