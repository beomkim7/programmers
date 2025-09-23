using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
            int length = id_list.Length;

            int[] answer = new int[length];

            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> Fcheck = new Dictionary<string, int>();
            foreach (string s in id_list)
            {
                dict[s] = 0;
                Fcheck[s] = 0;
            }
            
            report = report.AsEnumerable().Distinct().ToArray();
            
            for(int i = 0; i < report.Length; i++)
            {
                string check = report[i].Split(' ')[1];
                dict[check]++;
            }

            for(int i = 0; i < report.Length; i++)
            {
                string[] check = report[i].Split(' ');
                if (dict[check[1]] >= k) Fcheck[check[0]]++;
            }

            answer = Fcheck.Values.ToArray();

            return answer;
    }
}