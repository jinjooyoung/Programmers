using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        List<int> a = new List<int>();
        
        for (int i = start_num; i <= end_num; i++)
        {
            a.Add(i);
        }
        
        return a.ToArray();
    }
}