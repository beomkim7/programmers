using System;

public class Solution {
        public string[] solution(string[] quiz)
        {
            string[] answer = new string[quiz.Length];

            for(int i = 0; i < quiz.Length; i++)
            {
                string[] stArr = quiz[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                answer[i] =Calc(stArr[0], stArr[2], stArr[1]) ==int.Parse(stArr[4])?"O":"X"; //"X", "O"
            }

            return answer;
        }

        public int Calc(string num1,string num2,string check)
        {
            int result = 0;
            if(check == "+") result = int.Parse(num1) + int.Parse(num2);
            else if(check == "-") result = int.Parse(num1) - int.Parse(num2);

            return result;
        }
}