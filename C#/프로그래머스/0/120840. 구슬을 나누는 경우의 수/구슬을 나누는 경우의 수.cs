using System;

public class Solution {
        public double solution(int balls, int share)
        {
            int answer = 0;
            double up = 1;
            double down = 1;
            for (int i = share + 1; i <= balls; i++) up *= i;
            for (int i = 1; i <= balls-share; i++) down *= i;
            answer = (int)(up / down);
            if (balls == share) answer = 1;
            return answer;
        }
}