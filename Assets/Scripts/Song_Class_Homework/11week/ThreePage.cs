using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePage : MonoBehaviour
{
    // ���α׷����� ���� 11���� �����ڷ�
    // 3������
    // Break Ű����

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;

        while (true)
        {
            sum += 10;
            Debug.Log(sum);
            if (sum % 100 == 0 )
            {
                break;
            }
        }
    }
}
