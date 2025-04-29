using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] dots) {
            int answer = 0;

            List<int> XRange = new List<int>();
            List<int> YRange = new List<int>();

            for(int i = 0; i < dots.GetLength(0); i++)
            {
                XRange.Add(dots[i, 0]);
                YRange.Add(dots[i, 1]);
            }

            int x = XRange.Max() - XRange.Min();
            int y = YRange.Max() - YRange.Min();

            answer = x * y;
            return answer;
    }
}