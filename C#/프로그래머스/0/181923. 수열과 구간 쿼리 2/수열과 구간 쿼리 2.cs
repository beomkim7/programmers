using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            List<int> lst = new List<int>();
                    

            for(int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                int check = queries[i, 2];

                int num = arr.Skip(start)
                            .Take(end - start + 1)
                            .Where(x => x > check)
                            .DefaultIfEmpty(-1)
                            .Min();
                lst.Add(num);
            }

            return lst.ToArray();
    }
}