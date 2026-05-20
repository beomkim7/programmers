using System;
using System.Linq;
public class Solution {
    public int solution(int[,] sizes) {
            int answer = 0;
            int[] Maxcheck = new int[sizes.GetLength(0)];
            int[] MinCheck = new int[sizes.GetLength(0)];
            
            for(int i = 0 ; i < sizes.GetLength(0); i++)
            {
                Maxcheck[i] = Math.Max(sizes[i,0],sizes[i,1]);
                MinCheck[i] = Math.Min(sizes[i, 0], sizes[i, 1]);
            }

            answer = Maxcheck.Max() * MinCheck.Max();
            return answer;
    }
}