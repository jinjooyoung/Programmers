using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Seven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if ���ǹ�
        int inputNumber = 2021;

        if (inputNumber % 2 == 0)
        {
            Debug.Log("¦���Դϴ�.");
        }
        else
        {
            Debug.Log("Ȧ���Դϴ�.");
        }

        //switch ���ǹ�
        switch (inputNumber % 2)
        {
            case 0:
                Debug.Log("¦���Դϴ�.");
                break;
            case 1:
                Debug.Log("Ȧ���Դϴ�.");
                break;

                //break Ű���� : switch ���ǹ� �Ǵ� �ݺ����� �������� �� ���
                //switch ���ǹ� ��ȣ �ȿ��� ���� �� �Է�, �Է°��� �������� Ư�� �ڵ� ����
                //�Է��� ǥ���İ� case Ű���� ���� ǥ���� ������, case Ű���� �ٷ� ���� ���� ���ʷ� ����
        }
        //break�� ������ ���ǿ� ���� �ʾƵ� ��µ� �� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
