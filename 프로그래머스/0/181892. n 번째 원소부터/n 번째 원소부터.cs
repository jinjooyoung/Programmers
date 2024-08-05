using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length-n+1];
        int count = 0;
        
        if (num_list.Length-n == 0)
        {
            answer[0] = num_list[n-1];
        }
        else if(n == 1)
        {
            for (int q = 0; q < answer.Length; q++)
            {
                answer[count] = num_list[q];
                count++;
            }
        }
        else
        {
            for (int i = n-1; i < num_list.Length; i++)
            {
                answer[count] = num_list[i];
                count++;
            }
        }
        
        
        return answer;
    }
}