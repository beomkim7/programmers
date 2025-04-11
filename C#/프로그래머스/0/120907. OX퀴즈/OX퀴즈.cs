using System;

public class Solution {
    public string[] solution(string[] quiz) {
            string[] answer = new string[quiz.Length];

            for(int j = 0; j<quiz.Length;j++ )
            {
                string input = "";
                string[] check = quiz[j].Split(new string[] { " " }, StringSplitOptions.None);
                
                if(check[1]=="-") input = int.Parse(check[0])- int.Parse(check[2])==int.Parse(check[4])?"O":"X";
                else input = int.Parse(check[0]) + int.Parse(check[2]) == int.Parse(check[4]) ? "O" : "X";

                answer[j] = input;
            }
            return answer;
    }
}