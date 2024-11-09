#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
int solution(const char* t, const char* p) {
    int answer = 0;
    int tLength = strlen(t);
    int pLength = strlen(p);
    long long pInt = atoll(p);
    char part[pLength + 1];  // 부분 문자열 저장
    // C는 C#과 다르게 string이 없어서 char 배열로 문자열을 표시.
    // char 배열은 마지막 null로 끝을 명시해줘야하기 때문에 length + 1로 배열 크기 설정
    
    for (int i = 0; i <= tLength - pLength; i++)
    {
        strncpy(part, t + i, pLength);
        part[pLength] = '\0'; // null 문자로 끝을 표시
        
        // C#에서의 .Parse()와 같은 기능
        long long a = atoll(part);     // 부분 문자열의 숫자
        
        if (a <= pInt)
        {
            answer++;
        }
    }
    
    return answer;
}