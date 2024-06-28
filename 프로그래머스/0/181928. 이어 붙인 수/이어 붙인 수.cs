using System;

public class Solution {
    public int solution(int[] num_list) {
        int a = 0;
        string odd = "";
        string even = "";
        
        for (int i = 0; i < num_list.Length; i++)
        {
            a = num_list[i];
            if (a%2 == 0)
            {
                even += a.ToString();
            }
            else
            {
                odd += a.ToString();
            }
        }
        return int.Parse(even) + int.Parse(odd);
    }
}