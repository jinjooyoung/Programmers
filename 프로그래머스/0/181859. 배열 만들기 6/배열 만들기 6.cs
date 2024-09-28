using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> stk = new List<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (stk.Count == 0)
            {
                stk.Add(arr[i]);
            }
            else
            {
                if(stk[stk.Count-1] == arr[i])
                {
                    stk.RemoveAt(stk.Count-1);
                }
                else
                {
                    stk.Add(arr[i]);
                }
            }
        }
        
        if (stk.Count==0)
        {
            stk.Add(-1);
        }
        return stk.ToArray();
    }
}