using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Four : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("�����Դϴ�.");
        }

        else if (DateTime.Now.Hour > 12)
        {
            Debug.Log("�����Դϴ�.");
        }
        //else if �� if�� ���ǿ� ���� �ʴ� ��Ȳ������ if��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
