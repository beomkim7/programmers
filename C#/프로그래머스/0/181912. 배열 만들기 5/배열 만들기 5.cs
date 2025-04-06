using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
List<int> answer = new List<int>();

            for (int i = 0; i < intStrs.Length; i++)
                if (int.Parse(intStrs[i].Substring(s, l)) > k) answer.Add(int.Parse(intStrs[i].Substring(s, l)));

            return answer.ToArray();
    }
}