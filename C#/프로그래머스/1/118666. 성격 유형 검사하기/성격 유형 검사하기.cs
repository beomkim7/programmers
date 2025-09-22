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
                int score = Math.Abs(choices[i] - 4);
                if (choices[i] < 4)
                {
                    char c = survey[i][0];
                    string key = new string(survey[i].OrderBy(x => x).ToArray());
                    int dictNum = key.IndexOf(c);

                    dict[key][dictNum] += score;
                }
                else if(choices[i] > 4)
                {
                    char c = survey[i][1];
                    string key = new string(survey[i].OrderBy(x => x).ToArray());
                    int dictNum = key.IndexOf(c);

                    dict[key][dictNum] += score;
                }
            }
            
            foreach(var a in dict)
            {
                char first = a.Key[0];
                char second = a.Key[1];
                int firstN = a.Value[0];
                int secondN = a.Value[1];

                answer += firstN >= secondN ? first : second;
            }

            return answer;
    }
}