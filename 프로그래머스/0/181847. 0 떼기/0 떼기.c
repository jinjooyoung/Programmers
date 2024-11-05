#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
char* solution(const char* n_str) {
    int i = 0;
    while (n_str[i] == '0')
    {
        i++;
    }
    
    // n_str을 복사하는데 +i 위치에서 복사
    char* result = strdup(n_str + i);
    return result;
}