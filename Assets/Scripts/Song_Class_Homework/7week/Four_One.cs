using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_One : MonoBehaviour
{
    //�⺻���� 4-1

    // Start is called before the first frame update
    void Start()
    {
        int[] intArray = { 52, 273, 32, 65, 103 };
        //�迭 ���� �ڷ���[] �̸� = [�ڷ�, �ڷ� ...];

        intArray[0] = 0;
        //�迭�� ��Ҹ� �����մϴ�
        //�迭�� ù��°�� 0�̰� 0, 1, 2... ������

        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);
        //��� ���. �迭�� ù��°�� 52�� 9���� �����Ͽ����� 52�� �ƴ� 0�� ��µɰ���.

        Debug.Log(intArray.Length);
        //�迭�� ���̸� ��� (5)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
