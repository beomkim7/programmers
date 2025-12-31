using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(string s) {
            String answer = "";
            StringBuilder sb = new StringBuilder();
            string[] sArr = s.Split(' ');
            List<int> sNum = new List<int>();
            foreach (string st in sArr) sNum.Add(int.Parse(st));

            sb.Append(sNum.Min().ToString());sb.Append(' ');
            sb.Append(sNum.Max().ToString());

            return sb.ToString();
    }
}