using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four__One : MonoBehaviour
{
    // ���α׷����� ���� 11���� �����ڷ�
    // ���뿹�� 4-1
    // ���ڿ� ó��

    // Start is called before the first frame update
    void Start()
    {
        // 1. �빮�ڿ� �ҹ���ȭ
        string input = "Potato Tomato";
        Debug.Log(input.ToUpper());
        Debug.Log(input.ToLower());
        Debug.Log(input);       // Potato Tomato �� ��µ�


        // 2. ���ڿ� �ڸ���
        string input2 = "���� ���� �丶��";
        string[] inputs = input2.Split(new char[] { ' ' });

        foreach (var item in inputs)
        {
            Debug.Log(item);
        }


        // 3. ���ڿ� �� ���� ���� ����
        string input3 = " test        ";
        Debug.Log("::" + input3.Trim() + "::");


        // 4. �迭�� ���ڿ��� ��ȯ
        string[] array = { "����", "����", "�丶��", "����" };
        Debug.Log(string.Join(", ", array));
    }
}
