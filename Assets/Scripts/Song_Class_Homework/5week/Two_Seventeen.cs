using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Seventeen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ���� ������
        int output = 0;
        output += 52;       //0�� 52�� ���Ѱ��� output�� ����
        output += 273;      //52�� 273�� ���Ѱ��� output�� ����
        output += 103;      //325�� 103�� ���Ѱ��� output�� ����

        Debug.Log(output);      //���� �������� ������ output���� ���

        /*+= ���� �� ���� ������
        -= ���� �� ���� ������
        *= ���� �� ���� ������
        /= ������ �� ���� ������*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
