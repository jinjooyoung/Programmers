using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Six : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ڵ� �ڷ��� ��ȯ

        /*���� �ڷ��� --> �ڵ� ��ȯ�Ǵ� �ڷ���
        int             long, float, double
        long            float, double
        char            int, long, float, double
        float           double*/

        //int �ڷ����� ���ڸ� ����
        int intNumber = 2147483647;

        //int �ڷ����� long �ڷ������� �ڵ� ��ȯ
        long intToLong = intNumber;
        Debug.Log(intToLong);

        //int �ڷ����� double �ڷ������� �ڵ� ��ȯ
        double intToDouble = intNumber;
        Debug.Log(intToDouble);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
