using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string letter) {
string answer = "";
            List<char> Clst = new List<char>();
            for (char i = 'a'; i <= 'z'; i++)
                Clst.Add(i);

            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            Dictionary<string, char> dict = new Dictionary<string, char>();
            for (int i = 0; i < Clst.Count; i++)
                dict.Add(morse[i], Clst[i]);

            string[] letters = letter.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < letters.Length;i++)
                answer += dict[letters[i]];
            return answer;
    }
}