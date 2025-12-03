using System;

public class Solution {
    public int solution(int[,] sizes) {
            int answer = 0;

            int maxV = 0;
            int minV = 0;

            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                int nowMax = Math.Max(sizes[i, 0], sizes[i, 1]);
                int nowMin = Math.Min(sizes[i, 0], sizes[i, 1]);

                maxV = Math.Max(maxV, nowMax);
                minV = Math.Max(minV, nowMin);
            }

            answer = maxV * minV;

            return answer;
    }
}