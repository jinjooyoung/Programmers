using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        // 번호, 등수
        Dictionary<int, int> ranks = new Dictionary<int, int>();
        
        for(int i = 0; i < rank.Length; i++)
        {
            if (attendance[i])  // 참석 가능만
            {
                ranks[i] = rank[i];
            }
        }
        
        //OrderBy 딕셔너리 등수 기준 오름차순 정렬
        //Take() 앞에서 3등 가져옴
        //그중에서 번호만 얻어옴
        //배열로 변환
        var top3 = ranks.OrderBy(a => a.Value).Take(3).Select(a => a.Key).ToArray();
        
        int answer = 10000*top3[0]+100*top3[1]+top3[2];
        
        return answer;
    }
}