using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
            int answer = 0;

            int box = score.Length / m;
            Queue<int> que = new Queue<int>();
            score = score.OrderByDescending(x=>x).ToArray();

            for (int i = 0; i < score.Length; i++) que.Enqueue(score[i]);
            for(int i = 1; i <= box; i++)
            {
                int[] boxScore = new int[m];
                for (int j = 1; j <= m; j++) boxScore[j - 1] = que.Dequeue();
                answer += boxScore[boxScore.Length - 1] * m;
            }
            return answer;
    }
}