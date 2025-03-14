using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> answer = new List<string>();

        for (int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i] == "l")
            {
                // "l"의 왼쪽 요소들만 저장
                for (int j = 0; j < i; j++)
                    answer.Add(str_list[j]);
                return answer.ToArray();
            }
            else if (str_list[i] == "r")
            {
                // "r"의 오른쪽 요소들만 저장
                for (int j = i + 1; j < str_list.Length; j++)
                    answer.Add(str_list[j]);
                return answer.ToArray();
            }
        }

        return new string[0]; // "l"이나 "r"이 없을 경우 빈 배열 반환
    }
}
