using System;

public class Solution {
        public int solution(int left, int right)
        {
            int answer = 0;
            for(int i = left; i <= right; i++)
            {
                if (checkNo(i) % 2 == 0)
                    answer += i;
                else answer -= i;
            }

            return answer;
        }

        public int checkNo(int i)
        {
            int result = 0;
            for (int j = 1; j <= i / 2; j++)            
                if (i % j == 0) result++;

            result++;
            return result;
        }
}