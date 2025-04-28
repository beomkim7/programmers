using System;
using System.Linq;
public class Solution {
    public int solution(string my_string) {
            string[] stArr = my_string.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int answer = int.Parse(stArr[0]);

            for (int i = 0; i < stArr.Length; i++)
            {
                if (stArr[i].Contains("+")) answer += int.Parse(stArr[i + 1]);
                else if (stArr[i].Contains("-")) answer -= int.Parse(stArr[i + 1]);
            }
                

            return answer;
    }
}