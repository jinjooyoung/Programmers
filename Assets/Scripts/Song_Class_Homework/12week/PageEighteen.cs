using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageEighteen : MonoBehaviour
{
    // 12����
    // Math Ŭ����
    // �⺻���� 5-5 (Math Ŭ���� Ȱ��)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Abs(-999));         // ���밪          // 999�� ���
        Debug.Log(Mathf.Ceil(52.3f));       // �ø�            // 53�� ���
        Debug.Log(Mathf.Floor(52.8f));      // ����            // 52�� ���
        Debug.Log(Mathf.Max(52, 273));      // �� �� ū ��     // 273�� ���
        Debug.Log(Mathf.Min(52, 273));      // �� �� ���� ��   // 52�� ���
        Debug.Log(Mathf.Round(52.51f));     // �ݿø�          // 53�� ���
    }
}
