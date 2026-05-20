public class Solution {
    public string solution(string s) {
string answer = "";
            
            int cnt = 0;

            for(int i = 0 ; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    cnt = 0;
                    answer += s[i];
                }
                else
                {
if(cnt%2==0)answer +=char.ToUpper(s[i]);
                    else answer += char.ToLower(s[i]);
                    cnt++;
                }

            }

            return answer;
    }
}