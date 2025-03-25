public class Solution {
    public int solution(int num) {
        long answer = num;
        int count = 0;
        
        while (answer != 1)
        {
            if (answer % 2 == 0)    // 짝수라면
            {
                answer = answer/2;
            }
            else
            {
                answer = answer*3 + 1;
            }
            count++;
            if (count >= 500)
            {
                return -1;
            }
        }
        
        return count;
    }
}