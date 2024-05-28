using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageEighteen : MonoBehaviour
{
    // 12주차
    // Math 클래스
    // 기본예제 5-5 (Math 클래스 활용)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Abs(-999));         // 절대값          // 999가 출력
        Debug.Log(Mathf.Ceil(52.3f));       // 올림            // 53이 출력
        Debug.Log(Mathf.Floor(52.8f));      // 버림            // 52가 출력
        Debug.Log(Mathf.Max(52, 273));      // 둘 중 큰 것     // 273이 출력
        Debug.Log(Mathf.Min(52, 273));      // 둘 중 작은 것   // 52가 출력
        Debug.Log(Mathf.Round(52.51f));     // 반올림          // 53이 출력
    }
}
