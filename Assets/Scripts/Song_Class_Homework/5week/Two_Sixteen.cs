using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Sixteen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool one = 10 < 0;
        bool other = 20 > 100;

        Debug.Log(one);
        Debug.Log(other);
        //둘다 거짓이기 때문에 False가 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
