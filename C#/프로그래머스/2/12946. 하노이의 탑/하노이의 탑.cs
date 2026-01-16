using System;
using System.Collections.Generic;
public class Solution {
        private List<int[]> result= new List<int[]>();
        public int[][] solution(int n)
        {
            Hanoi(n, 1, 3, 2);
            return result.ToArray();
        }
        //[1,2] , [1,3] , [2,3]
        public void Hanoi(int num,int from,int to, int via)
        {
            if (num == 1) result.Add(new int[] { from, to });
            else
            {
                Hanoi(num - 1, from, via, to);
                result.Add(new int[] { from, to });
                Hanoi(num - 1, via, to,from);
            }
        }
}