using System;

public class Solution {
    public int solution(int a, int b, int n) {
            int answer = 0;

            while (n > 0)
            {
                answer += n / a * b;
                n = n % a + n / a *b;
if (n < a) break;
            }

            return answer;
    }
}