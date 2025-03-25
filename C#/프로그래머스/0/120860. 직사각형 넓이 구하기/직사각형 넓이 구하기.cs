using System;
using System.Linq;
public class Solution {
    public int solution(int[,] dots) {
            int answer = 0;
            int minX = Enumerable.Range(0, dots.GetLength(0)).Select(x => dots[x, 0]).Min();
            int maxX = Enumerable.Range(0, dots.GetLength(0)).Select(x => dots[x, 0]).Max();
            int minY = Enumerable.Range(0, dots.GetLength(0)).Select(x => dots[x, 1]).Min();
            int maxY = Enumerable.Range(0, dots.GetLength(0)).Select(x => dots[x, 1]).Max();
            answer = (maxX - minX) * (maxY - minY);


            return answer;
    }
}