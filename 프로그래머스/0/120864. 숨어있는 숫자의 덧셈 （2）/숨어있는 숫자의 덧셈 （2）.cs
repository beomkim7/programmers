using System;

public class Solution {
    public int solution(string my_string) {
            int answer = 0;
            char[] check = my_string.ToCharArray();

            for (char c = 'a'; c <= 'z'; c++)
                for (int i = 0; i < check.Length; i++)
                    if (check[i] == c) check[i] = ' ';
            for (char c = 'A'; c <= 'Z'; c++)
                for (int i = 0; i < check.Length; i++)
                    if (check[i] == c) check[i] = ' ';

            my_string = new string(check);
            string[] answerArr = my_string.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < answerArr.Length; i++)
                answer += int.Parse(answerArr[i]);

            return answer;
    }
}