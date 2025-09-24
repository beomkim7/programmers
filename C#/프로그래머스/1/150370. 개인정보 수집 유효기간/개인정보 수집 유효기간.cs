using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies)
        {
            List<int> answer = new List<int>();

            DateTime Dtoday = ConvertD(today);

            for(int i = 0; i < terms.Length; i++)
            {
                string[] termArr = terms[i].Split(' ');

                for(int j = 0; j < privacies.Length; j++)
                {
                    if (privacies[j].Contains(termArr[0]))
                    {
                        string[] priArr = privacies[j].Split(' ');
                        DateTime Edt = ConvertD(priArr[0]);
                        Edt = Edt.AddMonths(int.Parse(termArr[1]));

                        if (Edt <= Dtoday) answer.Add(j + 1);
                    }
                }

            }


            return answer.OrderBy(x=>x).ToArray();
        }

        public DateTime ConvertD(string s)
        {
            DateTime dt = Convert.ToDateTime(s.Replace('.','/'));
            return dt;
        }
}