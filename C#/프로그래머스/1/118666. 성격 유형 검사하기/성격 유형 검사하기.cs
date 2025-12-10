using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] survey, int[] choices) {
string answer = "";

            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();

            dict.Add("RT", new int[2] { 0, 0 });
            dict.Add("CF", new int[2] { 0, 0 });
            dict.Add("JM", new int[2] { 0, 0 });
            dict.Add("AN", new int[2] { 0, 0 });

            for(int i = 0; i < survey.Length; i++)
            {
                int score = Math.Abs(choices[i] - 4);

                if (choices[i] > 4)
                {
                    char c = survey[i][1];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());
                    int num = st.IndexOf(c);

                    dict[st][num] += score;
                }
                else if (choices[i] < 4)
                {
                    char c = survey[i][0];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());
                    int num = st.IndexOf(c);

                    dict[st][num] += score;
                }
            }

            foreach(var v in dict)
            {
                char first = v.Key[0];
                char second = v.Key[1];

                int firstS = v.Value[0];
                int SecondS = v.Value[1];

                answer += firstS >= SecondS ? first : second;

            }

            return answer;
    }
}