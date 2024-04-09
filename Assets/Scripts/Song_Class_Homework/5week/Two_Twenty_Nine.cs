using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Nine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //소숫점 제거

        double number = 52.273103;
        Debug.Log(number.ToString("0.0"));
        Debug.Log(number.ToString("0.00"));
        Debug.Log(number.ToString("0.000"));
        Debug.Log(number.ToString("0.0000"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
