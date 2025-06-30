using System;

public class Solution {
    public int solution(int[,] sizes) {
            int answer = 0;

            int maxV = 0;
            int minV = 0;

            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                int maxN = Math.Max(sizes[i, 0], sizes[i, 1]);
                int minN = Math.Min(sizes[i, 0], sizes[i, 1]);

                maxV = Math.Max(maxV, maxN);
                minV = Math.Max(minV, minN);
            }
            answer = maxV * minV;


            return answer;
    }
}