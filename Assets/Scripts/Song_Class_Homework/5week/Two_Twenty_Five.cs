using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Five : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //long �ڷ����� int �ڷ������� ��ȯ
        long longNumber = 2147483647L + 2147483647L;
        int longToInt = (int) longNumber;
        Debug.Log(longToInt);       //longŸ���� intŸ������ �����ϸ鼭 �����÷ο�

        //double �ڷ����� int �ڷ������� ��ȯ
        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;    //doubleNumber�� ����� ���� int�� �ٲپ� doubleToInt�� ���� (doubleNumber ��ü�� ���� ���ϴ� ���� �ƴ�)
        Debug.Log(doubleToInt);     //int�� �Ҽ����� �����Ƿ� 52 ���
        Debug.Log(doubleNumber);    //doubleNumber���� �ٲ�� �ƴϹǷ� ó���� ���� 52.27310332���

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
