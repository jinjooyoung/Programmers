using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Nineteen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ������ ��� ���� �հ� �ڿ� ++, --�� �ٿ� ����
        int number = 10;
        number++;       //�� ������ �����鼭 �ѹ��� 1�� ������
        Debug.Log(number);      //1�� ������ 11�� ��µ�
        number--;       //�� ������ �����鼭 �ѹ��� 1�� ����
        Debug.Log(number);      //1�� ���� 10�� ��µ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
