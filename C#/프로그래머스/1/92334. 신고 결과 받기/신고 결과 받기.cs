using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
int length = id_list.Length;
            int[] answer = new int[length];
            int[] receiver = new int[length];

            report = report.Distinct().ToArray();
            foreach(string s in report)
            {
                string reported = s.Split(' ')[1];
                int reported_idx = Array.IndexOf(id_list, reported);
                receiver[reported_idx]++;
            }

            for(int i = 0; i < report.Length; i++)
            {
                string reported = report[i].Split(' ')[1];
                int reported_idx = Array.IndexOf(id_list, reported);

                if (receiver[reported_idx] >= k)
                {
                    string reporter = report[i].Split(' ')[0];
                    int reporter_idx = Array.IndexOf(id_list, reporter);
                    answer[reporter_idx]++;
                }
            }

            return answer;
    }
}