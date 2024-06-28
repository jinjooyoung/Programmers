using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        
        int s = 0;
        int e = 0;
        int k = 0;
        
        for (int i = 0; i < arr.Length; i++)    // arr 복사
        {
            answer[i] = arr[i];
        }
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            s = queries[i,0];
            e = queries[i,1];
            k = queries[i,2];
            
            for (int j = s; j <= e; j++)
            {
                if (j%k == 0)
                {
                    answer[j] += 1;
                }
            }
        }
        
        
        return answer;
    }
}