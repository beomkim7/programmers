using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
            List<int> lst = new List<int>();
            for(int i = l;i<=r;i++)
            {
                string check = i.ToString();
                int cnt = 0;
                while (cnt < check.Length)
                {
                    check = check.Replace("5", "").Trim();
                    check = check.Replace("0", "").Trim();
                    cnt++;
                }
                if (string.IsNullOrEmpty(check)) lst.Add(i);
            }
            int[] answer = lst.Count == 0? new int[] { -1} :lst.ToArray();

            return answer;
    }
}