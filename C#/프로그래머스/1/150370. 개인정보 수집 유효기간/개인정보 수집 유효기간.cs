using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
List<int> answer = new List<int>();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for(int i = 0; i < terms.Length; i++)
            {
                string[] termsArr = terms[i].Split(' ');
                dict[termsArr[0]] = int.Parse(termsArr[1]);
            }

            DateTime checkDay = Convert.ToDateTime(today);
            for (int i = 0; i < privacies.Length; i++)
            {
                string[] priArr = privacies[i].Split(' ');
                string area = priArr[1];
                DateTime checkDel = Convert.ToDateTime(priArr[0]).AddMonths(dict[area]);

                if (checkDay >= checkDel) answer.Add(i+1);

            }

            return answer.ToArray();
    }
}