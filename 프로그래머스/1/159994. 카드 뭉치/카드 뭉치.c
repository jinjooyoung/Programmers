#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// cards1_len은 배열 cards1의 길이입니다.
// cards2_len은 배열 cards2의 길이입니다.
// goal_len은 배열 goal의 길이입니다.
// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
char* solution(const char* cards1[], size_t cards1_len, const char* cards2[], size_t cards2_len, const char* goal[], size_t goal_len) {
    size_t index1 = 0, index2 = 0;
    
    for (size_t i = 0; i < goal_len; i++)
    {
        if (index1 < cards1_len && strcmp(cards1[index1], goal[i]) == 0)
        {
            index1++;
        }
        else if (index2 < cards2_len && strcmp(cards2[index2], goal[i]) == 0)
        {
            index2++;
        }
        else
        {
            char* answer = (char*)malloc(3);
            strcpy(answer, "No");
            return answer;
        }
    }
    char* answer = (char*)malloc(4);
    strcpy(answer, "Yes");
    return answer;
}