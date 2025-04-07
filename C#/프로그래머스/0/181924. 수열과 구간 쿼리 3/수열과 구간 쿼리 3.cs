using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            int[] answer = (int[]) arr.Clone();

            for (int i = 0; i < queries.GetLength(0); i++) 
            {
                int st = queries[i, 0];
                int ed = queries[i, 1];

                int temp = answer[st];

                answer[st] = answer[ed];
                answer[ed] = temp;

            }
            return answer;
    }
}