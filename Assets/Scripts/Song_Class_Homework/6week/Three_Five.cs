using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Three_Five : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("아침 먹을 시간입니다.");
        }
        else
        {
            if (DateTime.Now.Hour < 15)
            {
                Debug.Log("점심 먹을 시간입니다.");
            }
            else
            {
                Debug.Log("저녁 먹을 시간입니다.");
            }
        }
        //11시 이전이라면 if문 명령어가 실행되고
        //11시 이후 라면 else문에서 한 번 더 조건이 걸려서 11시 이후, 15시 이전은 else의 if, 15시 이후는 else의 else가 실행
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
