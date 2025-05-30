using System;
using System.Collections.Generic;
using System.Linq;
    public class Solution
    {
        public int[] solution(int[] arr, int[] query)
        {
            List<int> check = arr.ToList();

            for(int i = 0; i < query.Length; i++)
            {
                if (i % 2 == 0)
                    check.RemoveRange(query[i]+1, check.Count - query[i]-1);
                else
                    check.RemoveRange(0, query[i]);
            }

            return check.ToArray();
        }
    }