using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
            int[] answer = new int[52];

            List<char> lc = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++)
                lc.Add(i);
            for (char i = 'a'; i <= 'z'; i++)
                lc.Add(i);


            for (int i = 0; i < my_string.Length; i++)
            {
                int check = lc.IndexOf(my_string[i]);
                answer[check]++;
            }
            return answer;
    }
}