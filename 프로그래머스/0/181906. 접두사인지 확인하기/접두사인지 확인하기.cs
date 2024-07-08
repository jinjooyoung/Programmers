using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        string[] a = new string[my_string.Length];
        for (int i = 0; i < my_string.Length; i++)
        {
            a[i] = my_string.Substring(0,i+1);
        }
        
        for (int i = 0; i < a.Length; i++)
        {
            if (is_prefix == a[i])
            {
                return 1;
            }
        }
        
        return 0;
    }
}