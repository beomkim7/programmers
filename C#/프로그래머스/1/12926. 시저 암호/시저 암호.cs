using System;
using System.Text;

public class Solution {
    public string solution(string s, int n) {
            StringBuilder answer = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                char check = s[i];
                if (s[i] == ' ') answer.Append(check);
                else if(char.IsUpper(check))
                {
                    check = (char)(check + n);
                    if (check > 'Z') check = (char)(check - 26);
                    answer.Append(check);
                }
                else if (char.IsLower(check))
                {
                    check = (char)(check + n);
                    if (check > 'z') check = (char)(check - 26);
                    answer.Append(check);
                }
            }

            return answer.ToString();
    }
}