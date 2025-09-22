using System;

public class Solution {
    public int solution(string s) {
            int answer = 0;



            for(int i = 0; i < s.Length; i++)
            {
                char check = s[i];
                int first = 1;
                int second = 0;

                for (int j = i + 1; j < s.Length; j++)
                {
                    if (first == second)
                    {
                        break;
                    }

                    if (check == s[j])
                    {
                        first++;
                        i++;
                    }
                    else
                    {
                        second++;
                        i++;
                    }                    
                }
                answer++;
            }

            return answer;
    }
}