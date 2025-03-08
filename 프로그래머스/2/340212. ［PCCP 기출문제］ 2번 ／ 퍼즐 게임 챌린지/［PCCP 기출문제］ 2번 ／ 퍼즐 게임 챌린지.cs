using System;

public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int answer = 1;
        int min = 1;
        int max = 100000;   // 1 ≤ diffs[i] ≤ 100,000 이므로
        
        while (min <= max)
        {
            int mid = (min + max) / 2;      // 중간값 (이번 반복에 사용할 레벨)
            long usedTimes = 0;
            
            for (int i = 0; i < diffs.Length; i++)
            {
                if (diffs[i] <= mid)
                {
                    usedTimes += times[i];
                }
                else
                {
                    int repeatCount = diffs[i] - mid;
                    
                    if (i > 0)
                    {
                        usedTimes += (times[i] + times[i - 1]) * repeatCount + times[i];
                    }
                }

                // 아직 diffs 모든 원소를 다 검사하지 않아도 도중에 초과하면 종료
                if (usedTimes > limit) break;
            }
            
            if (usedTimes > limit)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        
        answer = min;
        return answer;
    }
}