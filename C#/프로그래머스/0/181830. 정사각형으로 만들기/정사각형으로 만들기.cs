using System;

public class Solution {
    public int[,] solution(int[,] arr) {
            int maxLength = Math.Max(arr.GetLength(0), arr.GetLength(1));
            int[,] answer = new int[maxLength, maxLength];

            for(int i = 0; i < answer.GetLength(0); i++)
            {
                if (i >= arr.GetLength(0))
                    for (int j = 0; j < answer.GetLength(1); j++)
                        answer[i, j] = 0;
                else
                    for (int j = 0; j < arr.GetLength(1) ; j++)
                        answer[i, j] = arr[i,j];
            }

            return answer;
    }
}