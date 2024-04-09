using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Twenty_Eight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //문자열로 변환하는 매서드 ToString()
        Debug.Log((52).ToString());
        Debug.Log((52.273).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());

        Debug.Log((52).ToString().GetType());
        Debug.Log((52.273).ToString().GetType());
        Debug.Log(('a').ToString().GetType());
        Debug.Log((true).ToString().GetType());
        Debug.Log((false).ToString().GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
