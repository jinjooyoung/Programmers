using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageNineEleven : MonoBehaviour
{
    // 12����
    // Random Ŭ����
    // Ŭ������ Ȱ���� ������ ����, ������ �Ǽ� �������

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        random.Next();          // ������ �ƴ� ������ ���� ��ȯ
        random.Next(100);       // ������ �ƴϰ� 100 �̸��� ������ ���� ��ȯ (0~99)
        random.Next(10, 100);   // 10 <= x < 100 �� ������ ���� ��ȯ (10~99)

        // Random Ŭ������ ���Ǹ� �ν��Ͻ� random���� �ҷ�����
        // �� �Ʒ����� random�� dot(.)�� �ٿ��� RandomŬ������ �ִ� Next�� �ҷ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
