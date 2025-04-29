using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int l, int r) {
            List<int> answer = new List<int>();

            for(int i = l; i <= r; i++)
            {
                string check = i.ToString().Replace("5", " ").Replace("0", " ");
                if (check.Trim() == "") answer.Add(i);
            }
                    if (answer.Count == 0) answer.Add(-1);
            return answer.ToArray();
    }
}