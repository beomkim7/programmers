using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            int num = 1;
            while(num <= n)
            {
                num *= answer+1;
                answer++;
            }
            if (n < 2) answer = 2;


            return answer-1;
    }
}