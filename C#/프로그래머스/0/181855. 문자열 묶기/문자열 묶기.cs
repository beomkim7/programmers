using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
                        int answer = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            for(int i = 0; i < strArr.Length; i++)
            {
                int length = strArr[i].Length;
                if (dict.ContainsKey(length))
                {
                    dict[length] += 1;
                }
                else
                {
                    dict[length] = 1;
                }
            }
            answer = dict.Values.Max();
            return answer;
    }
}