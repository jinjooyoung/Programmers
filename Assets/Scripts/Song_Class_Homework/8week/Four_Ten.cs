using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Ten : MonoBehaviour
{
    // ���α׷����� ���� 10���� �����ڷ�
    // �⺻���� 4-10
    // foreach �ݺ����� varŰ����

    // Start is called before the first frame update
    void Start()
    {
        // ������ ���� �մϴ�.
        string[] array = { "���", "��", "����", "����", "�ٳ���" };

        // �ݺ��� �����մϴ�.
        // foreach (string item in array)
        foreach (var item in array)
        {
            //����մϴ�.
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
