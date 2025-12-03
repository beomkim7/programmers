using System;
using System.Linq;
public class Solution {
    public int solution(int n) {
            int answer = 0;
            string result = "";
            while (n > 0)
            {
                result += (n%3).ToString();
                n = n / 3;
            }
            Console.WriteLine(result);            
            for(int i = 0; i < result.Length; i++)
            {
                answer += int.Parse(result[i].ToString()) * (int)(Math.Pow(3.0, (result.Length -1- i)));//3  (result.Length - 1);
            }

            return answer;
    }
}