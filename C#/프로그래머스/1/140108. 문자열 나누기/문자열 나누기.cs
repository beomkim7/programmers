using System;

public class Solution {
    public int solution(string s) {
int answer = 0;
            char[] sArr = s.ToCharArray();

            int num = 0;
            int cnt = 0;            
            char prev = ' ';

            while (num < sArr.Length)
            {                
                char now = sArr[num];
                if (prev == ' ')
                {
                    prev = now;
                    cnt += 1;
                }
                else if (prev == now) cnt++;                
                else cnt--;

                if (cnt == 0)
                {
                    answer++;
                    prev = ' ';
                    cnt = 0;
                }
                num++;
            }
if (prev != ' ') answer += 1;
            return answer;
    }
}