using System;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(string X, string Y) {
            int[] XCheck = new int[10];
            int[] YCheck = new int[10];

            foreach (char c in X) XCheck[c - '0']++;
            foreach (char c in Y) YCheck[c - '0']++;

            StringBuilder sb = new StringBuilder();

            for(int i = 9; i >= 0; i--)
            {
                int num = Math.Min(XCheck[i], YCheck[i]);
                if (num > 0) sb.Append((char)(i + '0'), num);
            }

            string answer = sb.ToString();

            if (answer.Length==0) return "-1";
            else if (answer.Length !=0 && answer.All(x=>x=='0')) return "0";
            else return sb.ToString();      
    }
}