using System;
using System.Collections.Generic;
public class Solution {
public List<int[]> result = new List<int[]>();
        public int[][] solution(int n)
        {
            Hanoi(n, 1, 3, 2);

            return result.ToArray();
        }
        //2 [1,2], [1,3], [2,3] 
        public void Hanoi(int n,int from,int to, int via)
        {
            if (n == 1) result.Add(new int[] { from, to });
            else
            {
                Hanoi(n - 1, from, via, to);
                result.Add(new int[] { from, to });
                Hanoi(n - 1, via, to, from);
            }
        }
}