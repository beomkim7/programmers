using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
            List<int> answer = new List<int>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0; i < terms.Length; i++)
            {
                string[] sArr = terms[i].Split(' ');
                dict[sArr[0]] = int.Parse(sArr[1]);
            }

            for(int i = 0; i < privacies.Length; i++)
            {
                string[] sArr = privacies[i].Split(' ');
                int month = dict[sArr[1]];

                DateTime now = Convert.ToDateTime(today);
                DateTime check = Convert.ToDateTime(sArr[0]).AddMonths(month);
                if (now >= check) answer.Add(i+1);
            }

            return answer.ToArray();
    }
}