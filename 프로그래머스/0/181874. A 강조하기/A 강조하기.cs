using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        
        foreach (char a in myString)
        {
            if (a == 'a')
            {
                var temp = a.ToString();
                answer = answer + temp.ToUpper();
            }
            else if (a == 'A')
            {
                answer = answer + "A";
            }
            else
            {
                var temp = a.ToString();
                answer = answer + temp.ToLower();
            }
        }
        return answer;
    }
}