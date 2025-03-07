using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] board) {
        int answer = -1;
        int turnCount = 0;
        
        List<int> OList = new List<int>();
        List<int> XList = new List<int>();
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if(!board[i][j].Equals('.'))
                {
                    turnCount++;
                    if (board[i][j].Equals('O'))
                    {
                        OList.Add(i * 10 + j);
                    }
                    else if (board[i][j].Equals('X'))
                    {
                        XList.Add(i * 10 + j);
                    }
                }
            }
        }
        
        bool OBingo = CheckBingo(OList);
        bool XBingo = CheckBingo(XList);
        
        if (OList.Count == XList.Count || OList.Count == XList.Count + 1)
        {
            if (turnCount <= 5)
            {
                return 1;
            }
            else
            {
                if (turnCount%2 == 0)   // 짝수 턴이라면
                {
                    if (OBingo == false)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (XBingo == false)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        else
        {
            return 0;
        }
    }
    
    // 리스트를 받아서 빙고가 존재하는지 아닌지 bool 값을 리턴하는 함수
    public bool CheckBingo(List<int> list)
    {
        for (int i = 0; i < 3; i++)     // 한 번에 한 행, 한 열 동시에 검사
        {
            int row = i;    // 행
            int col = i;    // 열
            
            // 같은 라인에 같은 문자가 있는지 카운트 할 변수
            int rowC = 0;
            int colC = 0;
            int diagC1 = 0;
            int diagC2 = 0;
            
            // 각 문자의 행*10+열 을 원소로 갖는 리스트를 순회하며 카운트
            foreach (int pos in list)
            {
                if (pos / 10 == row) rowC++;
                if (pos % 10 == col) colC++;
                if (pos / 10 == pos % 10) diagC1++;
                if (pos / 10 + pos % 10 == 2) diagC2++;
            }
            
            // 카운트를 3번 했다면 빙고가 존재하므로 true 리턴
            if (rowC == 3 || colC == 3 || diagC1 == 3 || diagC2 == 3)
            {
                return true;
            }
        }
        return false;
    }
}