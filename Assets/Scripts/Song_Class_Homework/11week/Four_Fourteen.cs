using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Fourteen : MonoBehaviour
{
    // ���α׷����� ���� 11���� �����ڷ�
    // �⺻���� 4-14
    // Continue Ű����

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;       // ��Ƽ���� ������ �Ʒ� �ڵ带 �����ϰ� ���� �ݺ����� ���ư�
            }
            Debug.Log(i);
        }
    }
}
// 2�� �������� �� 0. �� ¦���� �� ��Ƽ���� ����ǹǷ�
// �ܼ�â���� Ȧ���� ��µɰ��� (1, 3, 5, 7, 9)