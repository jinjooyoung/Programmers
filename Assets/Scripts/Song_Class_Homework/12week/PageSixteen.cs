using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PageSixteen : MonoBehaviour
{
    // 12주차
    // List 클래스
    // 기본예제 5-4 (리스트 요소 추가 및 제거)

    // Start is called before the first frame update
    void Start()
    {
        // 리스트 변수 선언
        List<int> list = new List<int>();

        // 리스트에 요소 추가
        list.Add(52);
        list.Add(273);
        list.Add(32);
        list.Add(64);

        foreach (var item in list)      // 리스트 카운트 만큼 반복
        {
            Debug.Log("Count : " + list.Count + "\titem : " + item);    // \t는 Tab 처럼 긴 공백을 줌
        }

        list.Remove(52);
        // 52라는 요소를 삭제하였으므로 아래의 Debug.Log에서는 Count가 3이고 52를 제외한 나머지 요소들만 출력 된다

        foreach (var item in list)      // 리스트 카운트 만큼 반복
        {
            Debug.Log("Count : " + list.Count + "\titem : " + item);
        }
    }
}
