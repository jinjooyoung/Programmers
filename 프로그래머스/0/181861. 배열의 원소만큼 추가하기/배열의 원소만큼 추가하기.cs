using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> x = new List<int>();
        int count = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            while(arr[i] > count)
            {
                x.Add(arr[i]);
                count++;
            }
            count = 0;
        }
        
        return x.ToArray();
    }
}