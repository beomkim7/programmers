using System;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(int[] food) {
                        string answer = "";
            for(int i = 1; i < food.Length; i++)
            {
                int cnt = 0;
                if (food[i] == 1) continue;
                else
                {
                    cnt = food[i] / 2;
                }
                for (int j = 1; j <= cnt; j++) answer += i;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(answer.Reverse().ToArray());
            answer += "0";
            answer += sb.ToString();
            return answer;
    }
}