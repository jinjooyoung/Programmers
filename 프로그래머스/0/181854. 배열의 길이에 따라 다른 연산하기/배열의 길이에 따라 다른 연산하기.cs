using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        answer = (int[])arr.Clone();
        
        if (arr.Length % 2 == 0)
        {
            for(int i = 0; i < arr.Length; i+=2)
            {
                answer[i+1] += n;
            }
        }
        else
        {
            for(int i = 0; i < arr.Length; i+=2)
            {
                answer[i] += n;
            }
        }
        
        return answer;
    }
}