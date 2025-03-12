using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
            string answer = "";

            my_string = my_string.Remove(s, overwrite_string.Length);
            my_string = my_string.Insert(s, overwrite_string);

           answer = my_string;


            return answer;
    }
}