using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Six : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("��ħ ���� �ð��Դϴ�.");
        }
        else if (DateTime.Now.Hour < 15)
        {
            Debug.Log("���� ���� �ð��Դϴ�.");
        }
        else
        {
            Debug.Log("���� ���� �ð��Դϴ�.");
        }
        //�⺻���� 3-5�� ���� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
