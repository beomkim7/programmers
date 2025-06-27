using System;

public class Solution {
    public int solution(int[,] sizes) {
            int answer = 0;
            int max = 0;
            int min = 0;

            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                int big = Math.Max(sizes[i, 0], sizes[i, 1]);
                int small = Math.Min(sizes[i, 0], sizes[i, 1]);

                max = Math.Max(max, big);
                min = Math.Max(min, small);
            }

            answer = max * min;

            return answer;
    }
}