using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
            for (int i = 0; i < queries.GetLength(0);i++)
            {
                int st = queries[i, 0];
                int ed = queries[i, 1];
                int check = arr[st];

                arr[st] = arr[ed];
                arr[ed] = check;

            }
                return arr;
    }
}