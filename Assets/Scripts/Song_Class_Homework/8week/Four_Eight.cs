using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Eight : MonoBehaviour
{
    // ���α׷����� ���� 10���� �����ڷ�
    // �⺻���� 4-8
    // �� for �ݺ���

    // Start is called before the first frame update
    void Start()
    {
        // �迭 ����
        int[] intArray4 = { 1, 2, 3, 4, 5, 6 };     // Length �� 6�̰� 5������ ����

        // ����� ���� ���
        for ( int i = intArray4.Length - 1; i >= 0; i-- )   // i�� �迭 ���� 6 -1�� 5���� ���� �ϹǷ� 5��ȣ���� 6���� ���
        {
            Debug.Log(intArray4[i] );   // ����ϰ� i�� 1 �پ��� 4��ȣ���� 5�� ��� -> 0��ȣ���� 1���� ���ʴ�� ���
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
