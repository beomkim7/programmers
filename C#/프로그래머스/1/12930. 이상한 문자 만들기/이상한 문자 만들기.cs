using System;using System.Text;
public class Solution {
    public string solution(string s) {
            StringBuilder answer = new StringBuilder();
                int num = 0;
            for(int i = 0; i < s.Length; i++)
            {
                char check = s[i];

                if (check == ' ')
                {
                    num = 0;
                    answer.Append(" ");
                }
                else
                {
                    if (num % 2 == 0) answer.Append(char.ToUpper(check));
                    else answer.Append(char.ToLower(check));
                    num++;
                }

            }


            return answer.ToString();
    }
}