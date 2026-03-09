using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] cards) {
        bool[] visited = new bool[cards.Length];    // 상자를 열었는지 아닌지 체크
        List<int> groups = new List<int>();         // 상자 그룹들의 상자 수
        
        for (int i = 0; i < cards.Length; i++){
            if (visited[i]) continue;   // 이미 연 상자면 넘어감
            
            int count = 0;      // 상자를 연 횟수
            int current = i;
            
            // 열어야 하는 상자가 이미 열려있을 때까지 반복
            while(!visited[current]){
                visited[current] = true;        // 상자를 열었음 저장
                current = cards[current] - 1;   // 다음으로 열어야하는 번호 저장
                count++;
            }
            
            // 한 사이클 끝나면 상자 갯수 저장
            groups.Add(count);
        }
        
        // 열 수 있는 상자의 그룹이 2개 미만이면 0점
        if(groups.Count < 2)
            return 0;
        
        groups.Sort();
        groups.Reverse();
        
        // 열 수 있는 상자의 그룹 중 가장 많이 연 두 그룹의 수를 곱함
        return groups[0]*groups[1];
    }
}