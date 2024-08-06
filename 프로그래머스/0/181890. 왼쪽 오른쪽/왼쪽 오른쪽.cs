using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        List<string> list = new List<string>();
        int l_Index = Array.IndexOf(str_list, "l");
        int r_Index = Array.IndexOf(str_list, "r");
        
        if(l_Index == -1 && r_Index == -1)
        {
            return new string[0];
        }
        
        if (l_Index != -1 && r_Index == -1)
        {
            for (int i = 0; i < l_Index; i++)
            {
                list.Add(str_list[i]);
            }
        }
        else if (r_Index != -1 && l_Index == -1)
        {
            for (int t = r_Index + 1; t < str_list.Length; t++)
            {
                list.Add(str_list[t]);
            }
        }
        else
        {
            if (l_Index < r_Index)
            {
                for (int i = 0; i < l_Index; i++)
                {
                    list.Add(str_list[i]);
                }
            }
            else
            {
                for (int t = r_Index + 1; t < str_list.Length; t++)
                {
                    list.Add(str_list[t]);
                }
            }
        }
        
        return list.ToArray();
    }
}