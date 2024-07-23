using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> twoIndex = new List<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 2)
            {
                twoIndex.Add(i);
            }
        }

        if (twoIndex.Count > 1)
        {
            int start = twoIndex[0];
            int end = twoIndex[twoIndex.Count - 1];
            int[] answer = new int[end - start + 1];
            int count = 0;

            for (int k = start; k <= end; k++) {
                answer[count] = arr[k];
                count++;
            }
            return answer;
        }
        else if (twoIndex.Count == 1)
        {
            return new int[] {2};
        }
        else
        {
            return new int[] {-1};
        }
    }
}
