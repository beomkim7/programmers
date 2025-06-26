using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            string num = "";
            while (true)
            {                
                num += (n % 3).ToString();
                n = n / 3;
                if (n == 0) break;
            }

            for (int i = 0; i < num.Length; i++)
                answer += (int)(Math.Pow(3, num.Length-1-i))* int.Parse(num[i].ToString());

            return answer;
    }
}