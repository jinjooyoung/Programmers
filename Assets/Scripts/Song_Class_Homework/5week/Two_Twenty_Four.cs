using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Four : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� �ڷ��� ��ȯ�� ���� ������ �ս� ��
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int) longNumber;   //longNumber�� int�� ���� �� ���� ������ ū ���̹Ƿ�
        Debug.Log(intNumber);       //����ϸ� �����÷ο찡 �߻��Ͽ� ���� �̻��ϰ� ��µ�

        //���� �ڷ��� ��ȯ�� ���� ������ �ս� �߻����� �ʴ� ��
        long longNumber2 = 52273;
        int intNumber2 = (int) longNumber2;     //longNumber2�� int�� ���� �� �ִ� ������ ���� ���̹Ƿ�
        Debug.Log(intNumber2);      //����ϸ� ����� 52273�� ��µ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
