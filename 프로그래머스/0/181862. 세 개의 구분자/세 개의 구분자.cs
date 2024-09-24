using System;
using System.Linq;

public class Solution {
    public string[] solution(string myStr) {
        myStr = myStr.Replace("a", "c");
        myStr = myStr.Replace("b", "c");
        
        string[] answer = myStr.Split('c');
        
        answer = answer.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        
        if (answer.Length > 0)
        {
            return answer;
        }
        else
        {
            string[] empty = {"EMPTY"};
            return empty;
        }
    }
}