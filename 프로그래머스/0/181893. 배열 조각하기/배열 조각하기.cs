using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int start = 0;
        int end = arr.Length - 1;
        
        for(int i = 0; i < query.Length; ++i)
        {
            if(i % 2 == 0)
                end = Math.Min(start + query[i], end);
            else
                start = Math.Max(start + query[i], 0);
        }

        if(start > end) return new int[1]{ -1 };
        return arr.Skip(start).Take(end - start + 1).ToArray();
    }
}