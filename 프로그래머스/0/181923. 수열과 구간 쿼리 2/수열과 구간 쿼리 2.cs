using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        int s = 0;
        int e = 0;
        int k = 0;
        int mnV = 0;
        bool found = false;
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            s = queries[i,0];
            e = queries[i,1];
            k = queries[i,2];
            
            mnV = 1000000;
            found = false;
            
            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k && arr[j] <= mnV)
                {
                    mnV = arr[j];
                    found = true;
                }
            }
            
            answer[i] = found ? mnV : -1;
        }
        
        return answer;
    }
}