using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevenPage : MonoBehaviour
{
    // ���α׷����� ���� 11���� �����ڷ�
    // �������� 4-14
    // Continue Ű���� ���� ���� ����� ��µǵ���

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
