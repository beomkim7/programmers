using System;
using System.Linq;
public class Solution {
    public string solution(string a, string b) {
            int maxLength = Math.Max(a.Length, b.Length)+1;
            string answer = "";
            
            int up = 0;//285,734

            char[] aArray = a.PadLeft(maxLength, '0').Reverse().ToArray();
            char[] bArray = b.PadLeft(maxLength, '0').Reverse().ToArray();

            for(int i = 0; i < maxLength; i++)
            {
                int sum = int.Parse(aArray[i].ToString()) + int.Parse(bArray[i].ToString()) + up;
                up = sum / 10;
                answer += (sum % 10).ToString();
            }
            
            answer = new string(answer.Reverse().ToArray());
            if (answer[0] == '0') answer = answer.Substring(1);
            return answer;
    }
}