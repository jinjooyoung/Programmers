using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Eight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int inputNumber = 4;

        Debug.Log("�̹� ���� �� ���ΰ���: " + inputNumber);
        switch (inputNumber)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("�ܿ� �Դϴ�.");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("�� �Դϴ�.");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("���� �Դϴ�.");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("���� �Դϴ�.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
