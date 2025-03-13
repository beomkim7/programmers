using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
            Dictionary<int, int> check = new Dictionary<int, int>();

            for(int i = 0; i < strArr.Length; i++)
            {
                if (!check.ContainsKey(strArr[i].Length)) check[strArr[i].Length] = 1;
                else check[strArr[i].Length] += 1;
            }

            int answer = check.Values.Max();

            return answer;
    }
}