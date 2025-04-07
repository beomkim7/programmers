using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
            int answer = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < strArr.Length; i++)
            {
                if (!dict.ContainsKey(strArr[i].Length)) dict.Add(strArr[i].Length, 1);
                else dict[strArr[i].Length] += 1;
            }

            answer = dict.Values.Max();

            return answer;
    }
}