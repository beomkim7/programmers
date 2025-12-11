using System;using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
int[] answer = new int[id_list.Length];
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < id_list.Length; i++) dict[id_list[i]] = 0;

            report = report.Distinct().ToArray();
            for(int i = 0; i < report.Length; i++) dict[report[i].Split(' ')[1]]++;
            

            for(int i = 0; i < report.Length; i++)
            {
                string[] reportArr = report[i].Split(' ');
                string user = reportArr[0];
                string target = reportArr[1];

                if (dict[target] >= k)
                {
                    int Rowcount = Array.IndexOf(id_list, user);
                    answer[Rowcount]++;
                }
            }

            return answer;
    }
}