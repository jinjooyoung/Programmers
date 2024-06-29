using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> a = new List<int>();
        string iStr = "";
        
        for (int i = l; i <= r; i++)
        {
            iStr = i.ToString();
            
            if (iStr.Contains("1")) continue;
            if (iStr.Contains("2")) continue;
            if (iStr.Contains("3")) continue;
            if (iStr.Contains("4")) continue;
            if (iStr.Contains("6")) continue;
            if (iStr.Contains("7")) continue;
            if (iStr.Contains("8")) continue;
            if (iStr.Contains("9")) continue;
            
            a.Add(i);
        }
        
        if (a.Count == 0)
        {
            return new int [] {-1};
        }
        else
        {
            return a.ToArray();
        }
    }
}