using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        Array.Sort(citations);
        
        for(int i = citations.Length-1; i >= 0; i--){
            //if(citations[i]==0) continue;
            answer++;
            if(answer>citations[i]){
                answer--;
                break;
            }
            else if(answer==citations[i]){
                break;
            }
        }
        return answer;
    }
}