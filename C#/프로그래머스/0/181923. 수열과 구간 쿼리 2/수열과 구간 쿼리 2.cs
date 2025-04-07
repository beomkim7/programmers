using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            int[] answer = new int[queries.GetLength(0)];

            for(int i = 0; i < queries.GetLength(0); i++)
            {
                List<int> check = new List<int>();
                int st = queries[i, 0];
                int ed = queries[i, 1];
                for (int j = st; j <= ed; j++)
                    if (arr[j] > queries[i, 2]) check.Add(arr[j]);

                if(check.Count>0)
                    answer[i] = check.Min();
                else
                    answer[i] = -1;
            }
            return answer;
    }
}