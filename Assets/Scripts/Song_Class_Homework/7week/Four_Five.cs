using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Five : MonoBehaviour
{
    //�⺻���� 4-5 for�ݺ������� �����ϱ�

    // Start is called before the first frame update
    void Start()
    {
        int output = 0;

        for (int L = 0;  L <= 100; L++)
        {
            output += L;
        }

        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
