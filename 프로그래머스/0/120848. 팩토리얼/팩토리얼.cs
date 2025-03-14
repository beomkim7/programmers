using System;

public class Solution {
    public int solution(int n) {
            int answer = 1;
            int check = 1;
            for(int i = 1; i <= n; i++)
            {
                check *= i;
                if (check == n) break;
                
                else if (check > n)
                {
                    answer -= 1;
                    break;
                }
                answer++;
            }

            return answer;
    }
}