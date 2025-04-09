using System;

public class Solution {
    public int solution(int a, int b)         {
            int answer = 1;

            int makeGCD = gcd(a, b);
            if(makeGCD != 1)
            {
                a /= makeGCD;
                b /= makeGCD;
            }

            while (b > 1)
            {
                if (b % 2 == 0)
                {
                    b /= 2;
                    continue;
                }
                else if (b % 5 == 0)
                {
                    b /= 5;
                    continue;
                }
                else
                {
                    answer = 2;
                    break;
                }
            }

            return answer;
        }

        public int gcd(int a , int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
}