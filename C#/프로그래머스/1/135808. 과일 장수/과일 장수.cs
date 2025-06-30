using System;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
            int answer = 0;

            int[] check = new int[m];
            int count = 0;
            score = score.OrderByDescending(x => x).ToArray();

            for(int i =0; i < score.Length / m; i++)
            {
                count = 0;
                for (int j = i * m; j < i*m + m; j++)
                {
                    check[count] = score[j];
                    //Console.WriteLine(check[count]);
                    count++;
                }

                answer += check.Min() * m;
            }


            return answer;
    }
}