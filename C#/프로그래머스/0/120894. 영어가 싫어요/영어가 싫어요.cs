using System;
using System.Collections.Generic;

public class Solution {
    public long solution(string numbers) {
            long answer = 0;

            string[] check = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < check.Length; i++)
                dict.Add(check[i], i);

            for(int i = 0; i < check.Length; i++)            
                numbers = numbers.Replace(check[i], dict[check[i]].ToString());
            answer = long.Parse(numbers);
        
        return answer;
    }
}