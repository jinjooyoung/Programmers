using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        string[] a = new string[my_string.Length];
        for (int i = 0; i < my_string.Length; i++)
        {
            a[i] = my_string.Substring(i);
        }
        
        for (int i = 0; i < a.Length; i++)
        {
            if (is_suffix == a[i])
            {
                return 1;
            }
        }
        
        return 0;
    }
}
