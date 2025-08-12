using System;
using System.Linq;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
int length = id_list.Length;
            int[] answer = new int[length];
            int[] receive = new int[length];

            report = report.Distinct().ToArray();
            foreach (string item in report)
            {
                string received = item.Split(' ')[1];
                int reportCnt = Array.IndexOf(id_list, received);

                receive[reportCnt]++;
            }

            for (int i = 0; i < report.Length; i++)
            {
                string report_str = report[i].Split(' ')[1];
                int report_index = Array.IndexOf(id_list, report_str);

                if (receive[report_index] >= k)
                {
                    string send_str = report[i].Split(' ')[0];
                    int send_index = Array.IndexOf(id_list, send_str);
                    answer[send_index]++;
                }
            }


            return answer;
    }
}