using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = num_list[0];
        int a = 0;
        
        for (int i = 0; i < num_list.Length; i++)
        {
            if (answer < 0)
            {
                break;
            }
            if (answer > num_list[i])
            {
                answer = num_list[i];
                a = i;
            }
        }
        if (answer < 0)
        {
            return a;
        }
        else
        {
            return -1;
        }
    }
}