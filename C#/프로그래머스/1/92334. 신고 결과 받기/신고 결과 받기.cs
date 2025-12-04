using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
int[] answer = new int[id_list.Length];

            Dictionary<string, int> dict = new Dictionary<string, int>();
            report = report.Distinct().ToArray();
            for(int i = 0; i < report.Length; i++)
            {
string stSplit = report[i].Split(' ')[1];
                if (dict.ContainsKey(stSplit)) dict[stSplit]++;
                else dict[stSplit] = 1;
            }

            for(int i = 0; i < report.Length; i++)
            {
                string stSplit = report[i].Split(' ')[0];
                string stSplit2 = report[i].Split(' ')[1];

                if (dict[stSplit2] >= k)
                {
                    int no = 0;
                    for(int j = 0; j < id_list.Length; j++)
                    {
                        if (id_list[j] == stSplit)
                        {
                            no = j;
                            break;
                        }
                    }
                    answer[no]++;
                }

            }

            return answer;
    }
}