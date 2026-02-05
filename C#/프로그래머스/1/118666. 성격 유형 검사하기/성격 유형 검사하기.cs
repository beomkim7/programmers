using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string[] survey, int[] choices) {
string answer = "";
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
            dict.Add("RT", new int[] { 0, 0 });
            dict.Add("CF", new int[] { 0, 0 });
            dict.Add("JM", new int[] { 0, 0 });
            dict.Add("AN", new int[] { 0, 0 });

            for(int i = 0; i < survey.Length; i++)
            {
                int index = 0;
                if (choices[i] > 4) index = 1;
                int score = Math.Abs(choices[i] - 4);

                char c = survey[i][index];
                string st = new string(survey[i].OrderBy(x => x).ToArray());
                index = st.IndexOf(c);

                dict[st][index] += score;
            }

            foreach(var key in dict.Keys)
            {
                                int first = dict[key][0];
                int second = dict[key][1];

                if (first >= second) answer += key[0];
                else answer += key[1];
            }

            return answer;
    }
}