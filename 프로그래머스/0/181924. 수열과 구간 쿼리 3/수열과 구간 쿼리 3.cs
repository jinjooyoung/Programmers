using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        int n = 0;
        int m = 0;
        
        for (int i = 0; i < arr.Length; i ++)
        {
            answer[i] = arr[i];
        }
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            n = queries[i,0];
            m = queries[i,1];
            
            int temp = answer[n];
            answer[n] = answer[m];
            answer[m] = temp;
        }
        
        return answer;
    }
}