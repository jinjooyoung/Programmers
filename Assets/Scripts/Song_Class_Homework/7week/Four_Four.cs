using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Four : MonoBehaviour
{
    //�⺻���� 4-4 do while �ݺ��� Ȱ���ϱ�

    // Start is called before the first frame update
    void Start()
    {
        //while �ݺ����� ���´� ��������� ���Ǻ� �κ��� �������� ��ġ��.

        int k = 0;
        //���� ����

        do
        {
            Debug.Log(k + ") �ѹ��� �ݵ�� ��µ�.");
            ++k;
        }
        while (k < 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
