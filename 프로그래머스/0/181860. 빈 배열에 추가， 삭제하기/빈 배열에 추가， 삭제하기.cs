using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> x = new List<int>();
        
        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i]==true)
            {
                for (int t = 0; t < arr[i]*2; t++)
                {
                    x.Add(arr[i]);
                }
            }
            else
            {
                int a = arr[i];
                if (x.Count >= a)
                {
                    x.RemoveRange(x.Count - a, a);
                }
            }
        }
        
        return x.ToArray();
    }
}