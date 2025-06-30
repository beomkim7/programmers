using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            string Snum = "";
            while (n > 0)
            {
                Snum += (n % 3).ToString();
                n = n / 3;
            }

            for (int i = 0; i < Snum.Length; i++)
                answer += (int)(Math.Pow(3, Snum.Length - i - 1)) * int.Parse(Snum[i].ToString());
            
            return answer;
    }
}