using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Four_Seven : MonoBehaviour
{
    //�������� 4-7 2�� 10���� for���� ����Ͽ� ����ϱ�

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        int m = 1;
        for (int i = 1; i <= 10; i++)
        {
            m *= 2;
            Debug.Log("2�� " + i + "���� " + m);
            sum += m;
        }

        Debug.Log("��� �ջ��ϸ� " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
