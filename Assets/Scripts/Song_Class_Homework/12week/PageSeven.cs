using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSeven : MonoBehaviour
{
    // 12����
    // Ŭ������ ����
    // Ŭ���� ����� �ν��Ͻ� ����

    class Car
    {
        int carNumber;
        int inTime;
        int outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now.Hour;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now.Hour;
        }
    }
    // ��������� Car��� ���� ���� �� ������ Car�� �����Ȱ��� �ƴ�.
    // �Ʒ��� �ν��Ͻ��� ������ �� Car�� �Ӽ��� ���� car�� ������ ��.

    void Start()
    {
        Car car = new Car();    // ������� Ŭ����, �ν��Ͻ�(����), new Ű����, ������
        // ������ �Լ��� Ŭ������ ��ü�� ���ǵ� �� �ڵ����� ����Ǵ� �Լ�
        car.SetInTime();
        car.SetOutTime();
    }
}
