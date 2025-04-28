using System;using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            int length = queries.GetLength(0);
            int[] answer = new int[length];

            for(int i = 0; i < length; i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                int check = queries[i, 2];

                answer[i] = Enumerable.Range(start, end - start +1).Select(x => arr[x]).Where(x => x > check).DefaultIfEmpty(-1).Min();
            }
            return answer;
    }
}