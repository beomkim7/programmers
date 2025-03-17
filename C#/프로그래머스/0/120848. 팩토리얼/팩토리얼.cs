using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            int check = 1;
            
            while(check <= n)
            {
                check *= (answer + 1);
                answer++;
            }
answer--;
            if (n < 2) answer = 1;
            return answer;
    }
}