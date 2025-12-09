using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";

            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();

            dict.Add("RT", new int[2]);
            dict.Add("CF", new int[2]);
            dict.Add("JM", new int[2]);
            dict.Add("AN", new int[2]);

            for(int i = 0; i < survey.Length; i++)
            {
                if (choices[i] > 4)
                {
                    char c = survey[i][1];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());

                    int cnt = st.IndexOf(c);
                    dict[st][cnt] += choices[i] - 4;
                }
                else if (choices[i] < 4)
                {
                    char c = survey[i][0];
                    string st = new string(survey[i].OrderBy(x => x).ToArray());

                    int cnt = st.IndexOf(c);
                    dict[st][cnt] += 4 - choices[i];
                }
            }

            foreach(var v in dict)
            {
                char first = v.Key[0];
                char second = v.Key[1];

                int firstNo = v.Value[0];
                int secondNo = v.Value[1];

                if (firstNo >= secondNo) answer += first;
                else answer += second;

            }

            return answer;
    }
}