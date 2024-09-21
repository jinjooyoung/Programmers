using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x');
        Array.Sort(answer);
        answer = answer.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        return answer;
    }
}