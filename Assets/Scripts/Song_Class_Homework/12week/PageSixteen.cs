using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PageSixteen : MonoBehaviour
{
    // 12����
    // List Ŭ����
    // �⺻���� 5-4 (����Ʈ ��� �߰� �� ����)

    // Start is called before the first frame update
    void Start()
    {
        // ����Ʈ ���� ����
        List<int> list = new List<int>();

        // ����Ʈ�� ��� �߰�
        list.Add(52);
        list.Add(273);
        list.Add(32);
        list.Add(64);

        foreach (var item in list)      // ����Ʈ ī��Ʈ ��ŭ �ݺ�
        {
            Debug.Log("Count : " + list.Count + "\titem : " + item);    // \t�� Tab ó�� �� ������ ��
        }

        list.Remove(52);
        // 52��� ��Ҹ� �����Ͽ����Ƿ� �Ʒ��� Debug.Log������ Count�� 3�̰� 52�� ������ ������ ��ҵ鸸 ��� �ȴ�

        foreach (var item in list)      // ����Ʈ ī��Ʈ ��ŭ �ݺ�
        {
            Debug.Log("Count : " + list.Count + "\titem : " + item);
        }
    }
}
