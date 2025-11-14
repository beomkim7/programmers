using System;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
            int answer = 0;
            score = score.OrderByDescending(x => x).ToArray();

            for(int i = 0; i < score.Length / m; i++)
            {
                int[] check = new int[m];
                for(int j = 0; j < m; j++)
                {
                    check[j] = score[i * m + j];
                }
                answer += check[m-1] * m;
            }


            return answer;
    }
}