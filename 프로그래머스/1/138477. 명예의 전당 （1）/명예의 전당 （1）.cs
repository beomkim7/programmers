using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution {
    public int[] solution(int k, int[] score) {
            List<int> scoreLst = new List<int>();

            List<int> answer = new List<int>();
            for(int i = 0 ; i < score.Length; i++)
            {
                scoreLst.Add(score[i]);
                scoreLst = scoreLst.OrderByDescending(x=>x).ToList();

                if(scoreLst.Count > k)
                {
                    scoreLst.RemoveAt(scoreLst.Count-1);
                }
                answer.Add(scoreLst[scoreLst.Count-1]);
            }
            return answer.ToArray();
    }
}