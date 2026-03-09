using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        List<string> wordList = new List<string>();
        
        for(int i = 0; i < words.Length; i++){
            if(i != 0){
                if(words[i-1].Last() != words[i].First() || wordList.Contains(words[i])){
                    answer[0] = i % n+1;
                    answer[1] = i / n+1;
                    
                    break;
                }
            }
            
            wordList.Add(words[i]);
        }
        
        return answer;
    }
}