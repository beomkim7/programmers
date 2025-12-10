using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
            int[] answer = new int[id_list.Length];

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < id_list.Length; i++) dict[id_list[i]] = 0;

            report = report.Distinct().ToArray();

            for(int i = 0; i < report.Length; i++) dict[report[i].Split(' ')[1]]++;

            for (int i = 0; i < report.Length; i++)
            {
                string[] parseR = report[i].Split(' ');

                if(dict[parseR[1]] >= k)
                {
                    int check = Array.IndexOf(id_list, parseR[0]);
                    answer[check]++;
                }

            }


                return answer;
    }
}