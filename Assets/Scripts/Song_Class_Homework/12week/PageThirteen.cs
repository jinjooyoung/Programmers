using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageThirteen : MonoBehaviour
{
    // 12����
    // Random Ŭ����
    // �������� 8-1 (0~ 10.0������ ���� �Ǽ� 5��)

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(random.NextDouble() * 10);
        }

        // NextDouble() �޼���� 0.0 ~ 1.0 ������ ������ ���� ��ȯ��
        // 0.0 ~ 10.0������ ���� �Ǽ� 5���� �ʿ��ϹǷ� 10�� ���ؼ� �����
    }
}
