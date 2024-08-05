using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        int count = 0;
        
        for (int t = n; t < num_list.Length; t++)
        {
            answer[count] = num_list[t];
            count++;
        }
        for (int i = 0; i < n; i++)
        {
            answer[count] = num_list[i];
            count++;
        }
        
        return answer;
    }
}