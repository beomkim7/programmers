using System;

public class Solution {
    public string solution(string code) {
            string answer = "";
            bool check = false;
            for(int i = 0;i < code.Length; i++)
            {
                if (code[i] == '1')
                    check = !check;
                else if((!check && i%2==0)|| (check && i % 2 == 1)) 
                    answer += code[i].ToString();
            }
            if (answer == "") answer = "EMPTY";

            return answer;
    }
}