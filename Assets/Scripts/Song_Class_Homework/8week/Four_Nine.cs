using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Nine : MonoBehaviour
{
    // ���α׷����� ���� 10���� �����ڷ�
    // �⺻���� 4-9
    // foreach �ݺ����� �迭

    // Start is called before the first frame update
    void Start()
    {
        // ������ ���� �մϴ�.
        string[] array = { "���", "��", "����", "����", "�ٳ���" };

        // �ݺ��� �����մϴ�.
        foreach (string item in array)
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