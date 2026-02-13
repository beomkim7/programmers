using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
            List<int> answer = new List<int>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0; i < terms.Length; i++)
            {
                string[] sArr = terms[i].Split(' ');
                dict.Add(sArr[0], int.Parse(sArr[1]));
            }

            DateTime dt = Convert.ToDateTime(today);
            for(int i = 0; i < privacies.Length; i++)
            {
                string[] sArr = privacies[i].Split(' ');
                DateTime CheckD = Convert.ToDateTime(sArr[0]).AddMonths(dict[sArr[1]]);
                if (dt >= CheckD) answer.Add(i+1);
            }

            return answer.ToArray();
    }
}