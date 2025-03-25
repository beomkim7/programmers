using System;

public class Solution {
    public int solution(int balls, int share) {
            double answer = 1;

            for (int i = 1; i <= balls; i++) answer *= i;
            for (int i = 1; i <= share; i++) answer /= i;
            for (int i = 1; i <= balls - share; i++) answer /= i;

            
return Convert.ToInt32(answer);
    }
}