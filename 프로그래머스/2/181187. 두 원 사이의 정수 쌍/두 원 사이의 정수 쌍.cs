using System;

public class Solution {
    public long solution(int r1, int r2) {
        long answer = 0;
        long rr1 = (long)Math.Pow((long)r1,2);  // 작은 원 반지름 제곱
        long rr2 = (long)Math.Pow((long)r2,2);  // 큰 원 반지름 제곱
        
        for (long x = 0; x < r2; x++)
        {
            // 현재 x값에서 answer에 포함할 수 있는 최대 y값
            long maxY = (long)Math.Floor(Math.Sqrt(rr2-Math.Pow(x,2)));
            // 1. Math.Sqrt(rr2-Math.Pow(x,2)) : 피타고라스의 정리로 현재 x값에 해당하는 r2 원 위의 점의 y값(유리수)을 구함
            // 2. Floor로 음의 방향 내림 : 1에서 구한 y값이 정수라면 r2 원 위의 점이므로 그대로 내림해도 그대로 y. 포함
            // 그 외에는 정수가 아닌 유리수이므로 r2 원과 (음수 방향으로) 가장 가까운 정수 y부터 포함 (여기서의 정수 y가 바로 Math.Floor(Math.Sqrt(rr2-Math.Pow(x,2))))
            
            long minY;  // 현재 x값에서 answer에 포함할 수 있는 최소 y값
            
            if (r1 <= x)    // r1 <= x일 때 해당 x값에 대한 y > 0 인 모든 점이 가능
            {   // y==0인 점을 포함하지 않는 이유 : 한 사분면만 구해서 *4 시켜줄거라서. 이미 Y축 포함으로 계산 중이기 때문에 X축 위의 점은 세지 않음
                minY = 1;
            }
            else
            {
                minY = (long)Math.Ceiling(Math.Sqrt(rr1-Math.Pow(x,2)));
                // 위에서 구한 maxY와 비슷한 느낌. 근데 이젠 r1 원과 (양수 방향으로) 가장 가까운 정수 y니까 올림(Ceiling) 해줌
            }
            
            // 이제 현재 x에 가능한 점이 몇개 인지 answer에 더해줌
            answer += maxY-minY+1;
        }
        
        // 위 반복을 통해 한 사분면에서 가능한 answer를 구했으므로 마지막으로 *4해서 리턴
        return answer*4;
    }
}