using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
         List<string> list = new List<string>();
        int c = 0;
        
        for (int i = 0; i < names.Length; i++)
        {
            if (i%5 == 0)
            {
                list.Add(names[i]);
            }
        }
        
        return list.ToArray();
    }
}