#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// section_len은 배열 section의 길이입니다.
int solution(int n, int m, int section[], size_t section_len) {
    int a = 0;
    int answer = 0;
    
    if (n == m || section[section_len-1] - section[0] == m - 1)
    {
        return 1;
    }
    else if (m == 1)
    {
        return section_len;
    }
    else
    {
        for (int i = 0; i < section_len; i++)
        {
            if (i == 0)
            {
                answer++;
                a = section[i];
            }
            else
            {
                if (section[i]-a >= m)
                {
                    answer++;
                    a = section[i];
                }
            }
        }
    }
    
    return answer;
}