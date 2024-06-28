using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length + 1];
        
        int b_last = num_list[num_list.Length - 2];
        int last = num_list[num_list.Length - 1];
        
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }
        
        if (last > b_last)
        {
            answer[num_list.Length] = last - b_last;
        }
        else
        {
            answer[num_list.Length] = 2 * last;
        }
        
        return answer;
    }
}