using System;
using System.Text;
public class Solution {
    public string solution(string X, string Y) {
StringBuilder sb = new StringBuilder();

            int[] Xarr = new int[10];
            int[] Yarr = new int[10];

            foreach (char c in X) Xarr[c - '0']++;
            foreach (char c in Y) Yarr[c - '0']++;
            
            for(int i = 9; i >= 0; i--)
            {
                int cnt = Math.Min(Xarr[i], Yarr[i]);

                if (cnt > 0) sb.Append(new string((char)(i + '0'), cnt));
            }
            if (sb.Length == 0) return "-1";
            if (sb[0] == '0') return "0";


            return sb.ToString();
    }
}