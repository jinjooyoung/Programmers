using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Nine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ������ �⺻����
        //���� �������� �⺻���� [�� ǥ����] ? [��] : [����]
        string input = "-52273";        //�Է��� �ް�
        int number2 = int.Parse(input); //int������ ��ȯ��

        Debug.Log(number2 > 0 ? "�ڿ����Դϴ�." : "�ڿ����� �ƴմϴ�.");
        //��ȯ�� ���� 0���� ũ�� True�Ͻ� ���� "�ڿ����Դϴ�"�� ��µ�


        //���뿹��
        Debug.Log("����� ������ �ȳ��ϽŰ���?");
        string line = "�ȳ��մϴ�";

        if (line.Contains("�ȳ�")) //line�� ������ "�ȳ�"�̶�� ���ڿ��� �ִ°�?
        {
            Debug.Log("�ȳ��ϼ���!");    //�ִٸ� "�ȳ��ϼ���!" ���
        }
        else
        {
            Debug.Log("�߿� �ܿ��� ������ ���� �ɴϴ�.");    //���ٸ� �̰� ���
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
