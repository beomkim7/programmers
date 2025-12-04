using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
            int[] answer = new int[id_list.Length];

            Dictionary<string, int> dict = new Dictionary<string, int>();

            report = report.Distinct().ToArray();
            foreach(string s in report)
            {
                string[] sSplit = s.Split(' ');
                string first = sSplit[1];
                if (dict.ContainsKey(first)) dict[first]++;
                else dict[first] = 1;
            }

            for(int i = 0; i < report.Length; i++)
            {
                string[] sSplit = report[i].Split(' ');
                string first = sSplit[0];
                string second = sSplit[1];

                int num = Array.IndexOf(id_list, first);
                if (dict[second] >= k) answer[num]++;
            }

            return answer;
    }
}