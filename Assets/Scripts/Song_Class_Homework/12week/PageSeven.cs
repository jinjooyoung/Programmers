using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSeven : MonoBehaviour
{
    // 12주차
    // 클래스의 개요
    // 클래스 선언과 인스턴스 생성

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
    // 여기까지는 Car라는 것을 정의 한 것이지 Car가 생성된것은 아님.
    // 아래의 인스턴스를 생성할 때 Car의 속성을 가진 car가 생성된 것.

    void Start()
    {
        Car car = new Car();    // 순서대로 클래스, 인스턴스(변수), new 키워드, 생성자
        // 생성자 함수란 클래스가 객체로 정의될 때 자동으로 실행되는 함수
        car.SetInTime();
        car.SetOutTime();
    }
}
