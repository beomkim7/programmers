using System;

public class Solution {
    public int solution(string s) {
            int answer = 0;

            char[] sArr = s.ToCharArray();

            char now;
            char prev = ' ';

            int nowCnt = 0;
            int differ = 0;
            foreach(char c in sArr)
            {
                now = c;
                if (now == prev || prev == ' ')
                {
                    nowCnt++;
                    prev = c;
                }
                else differ++;

                
                if (nowCnt == differ)
                {
                    answer++;
                    nowCnt = 0;
                    differ = 0;
                    prev = ' ';
                }                
            }
            if (prev != ' ') answer++;

            return answer;
    }
}