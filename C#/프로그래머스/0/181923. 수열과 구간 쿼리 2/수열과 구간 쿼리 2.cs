using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            List<int> answer = new List<int>();

            for(int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                int check = queries[i, 2];

                int temp = -1;
                for(int j = start; j <= end; j++)
                {
                    if (arr[j] > check && temp == -1) temp = arr[j];
                    else if (arr[j] > check && arr[j] < temp) temp = arr[j];
                }

                answer.Add(temp);

            }

            return answer.ToArray();
    }
}