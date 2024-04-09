using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Thirty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(52 + 273);
        Debug.Log("52" + 273);
        Debug.Log(52 + "273");
        Debug.Log("52" + "273");

        //둘중 하나라도 문자열이라면 숫자도 문자열 취급되면서 52 뒤에 273이 이어져서 52273으로 출력됨
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
