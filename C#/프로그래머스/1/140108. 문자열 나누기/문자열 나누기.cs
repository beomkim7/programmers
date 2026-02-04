using System;

public class Solution {
    public int solution(string s) {
int answer = 0;
            int cnt = 0, prev = 0, next = 0;
            char check = ' ';
            while (s.Length > cnt) 
            {
                char c = s[cnt];

                if (check == ' ')
                {
                    check = c;
                    prev++;
                }
                else if (check == c) prev++;
                else if (check != c) next++;
                

                if(prev == next)
                {
                    answer++;
                    prev = 0; next = 0; check = ' ';
                }
                cnt++;
            }
            if (prev > 0) answer++;
            return answer;
    }
}