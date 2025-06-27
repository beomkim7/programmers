using System.Text;
public class Solution {
public string solution(string s)
{
    StringBuilder answer = new StringBuilder();
    int check = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            answer.Append(" ");
            check = 0; // 단어 경계 초기화
        }
        else
        {
            if (check % 2 == 0) answer.Append(char.ToUpper(s[i]));
            else answer.Append(char.ToLower(s[i]));
            check++;
        }
    }

    return answer.ToString();
}

}