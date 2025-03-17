using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] str_list) {
            List<string> answer = new List<string>();

            for(int i = 0; i < str_list.Length;i++)
            {
                if (str_list[i].Equals("l"))
                {
                    for (int j = 0; j < i; j++)
                        answer.Add(str_list[j]);
                    return answer.ToArray();
                }

                else if (str_list[i].Equals("r"))
                {
                    for (int j = i+1; j < str_list.Length; j++)
                        answer.Add(str_list[j]);
                    return answer.ToArray();
                }

            }
            return new string[0];
    }
}