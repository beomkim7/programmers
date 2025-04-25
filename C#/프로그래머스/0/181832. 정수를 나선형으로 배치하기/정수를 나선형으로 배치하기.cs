using System;

public class Solution {
    public int[,] solution(int n) {
            int[,] answer = new int[n,n] ;

            int right = 0;
            int left = n - 1;
            int up = 0;
            int down = n - 1;

            int check = 1;
            while(check <= n * n)
            {
                for (int i = right; i <= left; i++)
                {                    
                    answer[up, i] = check++;
                }                
                up++;
                for(int i = up;i<=down;i++)
                {
                    answer[i, left] = check++;
                }
                left--;
                for (int i = left; i >= right; i--)
                    answer[down, i] = check++;
                down--;
                for (int i = down; i >= up; i--)
                    answer[i, right] = check++;
                right++;
            }

            for(int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                    Console.Write(answer[i, j] + " ");

                Console.WriteLine();
            }

            return answer;
    }
}