using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] survey, int[] choices) {
string answer = "";
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            dict.Add("RT", new List<int> { 0, 0 });
            dict.Add("CF", new List<int> { 0, 0 });
            dict.Add("JM", new List<int> { 0, 0 });
            dict.Add("AN", new List<int> { 0, 0 });

            for(int i = 0; i < survey.Length; i++)
            {                
                int value = Math.Abs(choices[i] - 4);
                if (choices[i] < 4)
                {
                    char c = survey[i][0];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());
                    int check = st.IndexOf(c);

                    dict[st][check] += value;
                }
                else if (choices[i] > 4)
                {
                    char c = survey[i][1];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());
                    int check = st.IndexOf(c);

                    dict[st][check] += value;
                }
            }

            foreach(var v in dict)
            {
                char f = v.Key[0];
                char s = v.Key[1];

                int fNo = v.Value[0];
                int sNo = v.Value[1];

                answer += fNo >= sNo ? f : s;
            }

            return answer;
    }
}