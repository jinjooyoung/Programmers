using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Three_Five : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("��ħ ���� �ð��Դϴ�.");
        }
        else
        {
            if (DateTime.Now.Hour < 15)
            {
                Debug.Log("���� ���� �ð��Դϴ�.");
            }
            else
            {
                Debug.Log("���� ���� �ð��Դϴ�.");
            }
        }
        //11�� �����̶�� if�� ��ɾ ����ǰ�
        //11�� ���� ��� else������ �� �� �� ������ �ɷ��� 11�� ����, 15�� ������ else�� if, 15�� ���Ĵ� else�� else�� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
