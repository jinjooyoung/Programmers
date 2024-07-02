using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> a = new List<int>();
        
        for (int i = 0; i < intStrs.Length; i++)
        {
            int temp = Int32.Parse(intStrs[i].Substring(s, l));
            if (temp > k)
            {
               a.Add(temp); 
            }
        }
        
        return a.ToArray();
    }
}