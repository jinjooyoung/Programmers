using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Three : MonoBehaviour
{
    //�⺻���� 4-3 �ݺ��� �̿��ϱ�

    // Start is called before the first frame update
    void Start()
    {
        int j = 0;
        int[] intArray3 = { 52, 273, 32, 65, 103 };
        //���� ����

        while (j < intArray3.Length) //�ݺ� ����
        {
            Debug.Log(j + "��° ���" + intArray3[j]);
            //���

            j++;
            //Ż���� ���� ������ ����
            //�̰� ������ ���� ������ �ɷ� ��ǻ�Ͱ� �����
        }

        //j�� 0���� �����Ͽ� intArray3.Length�� 5���� �����Ƿ� While���� ����. ù��° ��Ҹ� ���.
        //����� �� j�� 1�� �����ϰ� 1�� intArray3.Length�� 5���� �����Ƿ� While���� ����. �ι�° ��Ҹ� ���.
        //�ݺ��ϴٰ� j�� �����Ͽ� 5�� �ȴٸ� intArray3.Length�� 5���� ���� �����Ƿ� ���̻� �ݺ����� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
