using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 10;
        Debug.Log(number);      //���� ���
        Debug.Log(number++);    //�ϴ� ������ ����ϰ� 1�� ���� > 10���
        Debug.Log(number--);    //�ϴ� ������ ����ϰ� 1�� ���� > 11���
        Debug.Log(number);      //���� ��� > ������ 1�� ����� ������ 10 ���
        
        Debug.Log(number);      //���� ���
        Debug.Log(++number);    //1�� ���� ������ ����� > 11
        Debug.Log(--number);    //1�� �� ������ ����� > 10
        Debug.Log(number);      //���� ��� > 10

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
