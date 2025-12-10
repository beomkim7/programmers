using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies)
        {
            int[] answer = new int[] { };
            List<int> answerArr = new List<int>();

            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

            for(int i = 0; i < terms.Length; i++)
            {
                string[] parseT = terms[i].Split(' ');
                dict.Add(parseT[0], ConverT(today).AddMonths(-int.Parse(parseT[1])));
            }

            for(int i = 0; i < privacies.Length; i++)
            {
                string[] parseT = privacies[i].Split(' ');
                DateTime priDt = ConverT(parseT[0]);

                if (dict[parseT[1]] >= priDt) answerArr.Add(i+1);
            }

            return answerArr.ToArray();
        }
        public DateTime ConverT(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            return dt;
        }
}