using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Two : MonoBehaviour
{
    //�⺻���� 4-2 ���ϴ� ũ���� �迭 ���� 

    // Start is called before the first frame update
    void Start()
    {
        int[] intArray2 = new int[100];
        //��ĭ�� �迭�� 100�� ����

        Debug.Log(intArray2[0]);
        Debug.Log(intArray2[99]);
        //��Ҹ� ���
        //���� �ڷ����� ��ĭ�̱⶧���� �� �� 0�� ��µɰ���.

        //Debug.Log(intArray2[100]); ��Ҹ� 100�� ���� 0���� ������ ���� ������ intArray2[100]�� �������� ���� 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
