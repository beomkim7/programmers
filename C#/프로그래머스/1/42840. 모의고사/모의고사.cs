using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
            List<int> answer = new List<int>();
            int Math1result = 0;
            int Math2result = 0;
            int Math3result = 0;

            int[] math = new int[] { 1, 2, 3, 4, 5 };
            int[] math2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] math3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            for(int i = 0; i < answers.Length;i++)
            {
                    if (math[i % 5] ==   answers[i]) Math1result++;
                    if (math2[i % 8] ==  answers[i]) Math2result++;
                    if (math3[i % 10] == answers[i]) Math3result++;                
            }

            int maxScore = Math.Max(Math1result, Math.Max(Math2result, Math3result));

            if(maxScore == Math1result) answer.Add(1);
            if(maxScore == Math2result) answer.Add(2);
            if(maxScore == Math3result) answer.Add(3);
            
            

            return answer.ToArray();
    }
}