using System;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(int[] food) {
            StringBuilder answer = new StringBuilder();

            for (int i = 1; i < food.Length; i++)
                for (int j = 0; j < food[i] / 2; j++)
                    answer.Append(i);
            
            string reverse = new string(answer.ToString().Reverse().ToArray());
            answer.AppendFormat("0{0}", reverse);

            return answer.ToString();
    }
}