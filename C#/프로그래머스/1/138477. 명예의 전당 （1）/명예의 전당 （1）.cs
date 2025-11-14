using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int k, int[] score) {
int[] answer = new int[score.Length];

            List<int> check = new List<int>();

            for(int i = 0; i < score.Length; i++)
            {
                check.Add(score[i]);
                check = check.OrderByDescending(x => x).ToList();
                if (check.Count > k) check.RemoveAt(check.Count - 1);
                answer[i] = check[check.Count - 1];
            }

            return answer;
    }
}