using System;

public class Solution {
    public string solution(string s, string skip, int index) {
string answer = "";

            for(int i = 0; i < s.Length; i++)
            {
                int num = 1;
                char c = s[i];
                while (num <= index)
                {
                    ++c;
                    if (c - '0' > 74) c = 'a';
                    if (skip.Contains(c)) continue;

                    num++;
                }
                answer += c;
            }

            return answer;
    }
}