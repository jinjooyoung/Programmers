using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Seven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ٸ� �ڷ����� ���ڷ� ��ȯ

        /*���ڿ��� ���ڷ� ��ȯ�ϴ� �ż���
        �ż��� �̸�      ����
        int.Parse()     �ٸ� �ڷ����� int �ڷ������� ����
        long.Parse()    �ٸ� �ڷ����� long �ڷ������� ����
        float.Parse()   �ٸ� �ڷ����� float �ڷ������� ����
        double.Parse()  �ٸ� �ڷ����� double �ڷ������� ����*/

        Debug.Log(int.Parse("52"));
        Debug.Log(long.Parse("273"));
        Debug.Log(float.Parse("52.273"));
        Debug.Log(double.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());       //�ش� ������ �ڷ����� ����
        Debug.Log(long.Parse("273").GetType());
        Debug.Log(float.Parse("52.273").GetType());
        Debug.Log(double.Parse("103.32").GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
