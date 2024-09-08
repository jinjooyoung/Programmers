using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = (int[])arr.Clone();
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            for (int a = s; a <= e; a++)
            {
                answer[a]++;
            }
        }
        
        return answer;
    }
}