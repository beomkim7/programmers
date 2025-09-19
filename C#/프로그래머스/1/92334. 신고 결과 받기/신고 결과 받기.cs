using System;
using System.Linq;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
            int length = id_list.Length;
            int[] answer = new int[length];

            int[] check = new int[length];
            report = report.AsEnumerable().Distinct().ToArray();

            for(int i = 0; i < report.Length; i++)
            {
                string s = report[i].Split(' ')[1];
                int num= Array.IndexOf(id_list, s);
                check[num]++;
            }

            int[] lcheck = new int[length];
            for (int i = 0; i < report.Length; i++)
            {
                string p = report[i].Split(' ')[0];
                string s = report[i].Split(' ')[1];

                int nump = Array.IndexOf(id_list, p);
                int num = Array.IndexOf(id_list, s);

                if (check[num] >= k) answer[nump]++;
            }


            return answer;
    }
}