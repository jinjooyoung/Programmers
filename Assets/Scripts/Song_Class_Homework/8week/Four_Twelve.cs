using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Twelve : MonoBehaviour
{
    // ���α׷����� ���� 10���� �����ڷ�
    // �������� 4-12
    // ��ø �ݺ��� - �� �Ƕ�̵� (2)

    // Start is called before the first frame update
    void Start()
    {
        string count = "";
        string stars = "";
        for (int i = 0; i < 10; i++)
        {
            count = "";     // �߰� for���� ������ ������ �ʱ�ȭ
            for (int j = 0; j < 9-i; j++) //0~9 10  0 ~ 8 9
            {
                count += " "; // 9�� �ݺ��Ͽ� ������ 9�� ����      // 2��° �ݺ� �� i�� 1�� �Ǿ����Ƿ� 8�� �ݺ��Ͽ� ������ 8�� ���� -> ������ 0�� �� ������ �ݺ�
            }
            stars += "*";                   //���� �ϳ� �߰���
            Debug.Log(count + stars);      // ���� �ڿ� ���� ���� ������ �ٿ��� �����      
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
