using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
            int[] answer = new int[] { };
            List<int> answerAdd = new List<int>();
            DateTime todatDT = parseDT(today);
            for(int i = 0; i < terms.Length; i++)
            {
                string[] check = terms[i].Split(' ').ToArray();
                for(int j = 0; j < privacies.Length; j++)
                {
                    if (privacies[j].Contains(check[0]))
                    {
                        string stDT = privacies[j].Substring(0, 10);
                        DateTime checkDT = parseDT(stDT);
                        checkDT = checkDT.AddMonths(int.Parse(check[1]));

                        if (todatDT >= checkDT) answerAdd.Add(j+1);
                    }
                }

            }

            return answerAdd.OrderBy(x=>x).ToArray();
        }

        private DateTime parseDT(string st)
        {
            st = st.Replace(".", "/");
            return DateTime.ParseExact(st, "yyyy/MM/dd", CultureInfo.InvariantCulture);
        }
}