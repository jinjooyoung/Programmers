using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Eleven : MonoBehaviour
{
    // ���α׷����� ���� 10���� �����ڷ�
    // �⺻���� 4-11
    // ��ø �ݺ��� - �� �Ƕ�̵� (1)

    // Start is called before the first frame update
    void Start()
    {
        string stars;
        for (int n = 0; n < 10; n++)
        {
            stars = "";
            for (int o = 0; o < n+1; o++)
            {
                stars += "*";
            }
            Debug.Log(stars);
        }

        /*string stars = "";
        for (int n = 0; n < 10; n++)
        {
            stars += "*";
            Debug.Log(stars);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
