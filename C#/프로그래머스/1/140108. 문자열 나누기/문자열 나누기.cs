using System;

public class Solution {
    public int solution(string s) {
            int answer = 0;

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int num = 1;
                int dif = 0;

                while(num != dif)
                {
                    if (i == s.Length - 1) break;
                    if (c == s[i + 1]) num++;
                    else dif++;
                    i++;
                }
                answer++;
            }

            return answer;
    }
}