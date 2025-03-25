using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    List<string> friendsList = new List<string>();  // friends 매개변수를 클래스의 전역 변수로 꺼냄
    List<int> giftScore = new List<int>();          // 각 사람마다 다음 달에 받을 선물 갯수를 저장
    
    public int solution(string[] friends, string[] gifts) {
        // friends의 값을 friendsList에 적용
        foreach(string name in friends)
        {
            friendsList.Add(name);
        }
        
        for (int i = 0; i < friends.Length; i++)
        {
            giftScore.Add(0);  // 각 사람에 대한 선물 갯수를 0으로 초기화
        }
        
        //=========================변수 선언부===============================
        
        // gifts의 원소를 공백 기준으로 나눈 이름을 저장할 크기 2 배열
        string[] splitName = new string[2];
        // 선물을 준 사람과 받은 사람을 저장할 2차원 배열 (입출력 예에 있는 표처럼)
        int[,] giftMatrix = new int[friends.Length, friends.Length];
        
        //=================================================================
        
        // gifts 배열을 돌면서 giftMatrix 표를 생성
        for (int i = 0; i < gifts.Length; i++)
        {
            splitName = gifts[i].Split();   // 이름 2개가 담긴 배열
            
            int giver = nameNum(splitName[0]);      // 선물을 준 사람의 번호
            int receiver = nameNum(splitName[1]);   // 선물을 받은 사람의 번호
            
            giftMatrix[giver, receiver]++;          // 2차원 배열(표)에 저장
        }
        
        // giftMatrix를 검사 (메인 로직)
        // 표로 그렸을 때 우하향 대각선을 기준으로 윗쪽 부분만 검사
        for (int i = 0; i < friends.Length-1; i++)  // 행
        {
            for (int j = i+1; j < friends.Length; j++)  // 열
            {
                if (i==j) continue;     // 자기자신과 주고받을 수 없으니 넘어감
                
                // 서로 주고 받은 기록이 있다면 true 없다면 false
                bool hasGifted = giftMatrix[i,j] + giftMatrix[j,i] > 0 ? true : false;
                
                if (hasGifted && giftMatrix[i,j] != giftMatrix[j,i])    // 주고받았고 그 수가 다를 때
                {
                    if (giftMatrix[i, j] > giftMatrix[j, i])    // i가 j보다 더 많은 선물을 줬으면
                    {
                        giftScore[i]++;  // i가 선물을 받음
                    }
                    else    // j가 i보다 더 많은 선물을 줬으면
                    {
                        giftScore[j]++;  // j가 선물을 받음
                    }
                }
                else if (!hasGifted || giftMatrix[i,j] == giftMatrix[j,i])  // 주고받은 기록이 없거나 같다면
                {
                    int i_giftNet = 0;  // 지금 반복에서 선물을 준 사람의 선물 지수
                    int j_giftNet = 0;  // 선물을 받은 사람의 선물 지수
                    
                    // 선물 지수 계산
                    for(int a = 0; a < friends.Length; a++)
                    {
                        i_giftNet += giftMatrix[i,a];
                        i_giftNet -= giftMatrix[a,i];
                        
                        j_giftNet += giftMatrix[j,a];
                        j_giftNet -= giftMatrix[a,j];
                    }
                    
                    if (i_giftNet > j_giftNet)          // i가 j보다 선물 지수가 크다면
                    {
                        giftScore[i]++;  // i가 선물을 받음
                    }
                    else if (i_giftNet == j_giftNet)    // i와 j의 선물 지수가 같다면
                    {
                        continue;
                    }
                    else if (i_giftNet < j_giftNet)     // j가 i보다 선물 지수가 크다면
                    {
                        giftScore[j]++;  // j가 선물을 받음
                    }
                }
            }
        }
        
        int maxGift = giftScore.Max();
        return maxGift;
    }
    
    // 계산을 쉽게 하기 위해 이름을 숫자로 변환 (프렌즈 배열 순서가 그 사람 숫자)
    public int nameNum(string name)
    {
        for (int i = 0; i < friendsList.Count; i++)
        {
            if (name == friendsList[i])
            {
                return i;
            }
        }
        
        return -1;
    }
}