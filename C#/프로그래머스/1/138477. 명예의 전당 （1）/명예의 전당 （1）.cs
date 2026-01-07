using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int k, int[] score) {
                                                int[] answer = new int[score.Length];
            List<int> scores = new List<int>();            
            
            for(int i = 0; i < score.Length; i++)
            {
                scores.Add(score[i]);
                scores = scores.OrderByDescending(x => x).ToList();
                if (scores.Count > k) scores.RemoveAt(k);
                answer[i] = scores[scores.Count - 1];
            }

            return answer;
    }
}