using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Fifteen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string message = "�ȳ��ϼ���";   //message ��� ������ ������ �ȳ��ϼ��� ����

        Debug.Log(message + "!");   //������ ������ ������ ���� !�� �߰��Ͽ� �����
        Debug.Log(message[0]);      //������ ù��° ���ڸ� ���
        Debug.Log(message[1]);      //������ �ι�° ���ڸ� ���
        Debug.Log(message[2]);      //������ ����° ���ڸ� ���

        Debug.Log("�ȳ��ϼ���"[0]);      //�ȳ��ϼ��� ��� ���ڿ��� ù��° ���ڸ� ���
        Debug.Log("�ȳ��ϼ���"[1]);      //�ȳ��ϼ��� ��� ���ڿ��� �ι�° ���ڸ� ���
        Debug.Log("�ȳ��ϼ���"[2]);      //�ȳ��ϼ��� ��� ���ڿ��� ����° ���ڸ� ���

        //Debug.Log("string : " + sizeof(string));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
