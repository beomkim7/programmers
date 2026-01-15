using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(string s) {
            StringBuilder sb = new StringBuilder();
            List<int> spArr = new List<int>();
            if (int.TryParse(s[0].ToString(), out int result)) sb.Append(s[0]);
            else sb.Append(s[0].ToString().ToUpper());

            for (int i = 0; i < s.Length; i++)            
                if (s[i] == ' ')                 
                    spArr.Add(i+1);                    
                
            

            for(int i = 1;i<s.Length;i++)
            {
                if (spArr.Contains(i))
                {
                    if (int.TryParse(s[i].ToString(), out int result2)) sb.Append(s[i]);
                    else sb.Append(s[i].ToString().ToUpper());
                }
                else
                {
                    if (int.TryParse(s[i].ToString(), out int result2)) sb.Append(s[i]);
                    else sb.Append(s[i].ToString().ToLower());
                }
            }

            return sb.ToString();
    }
}