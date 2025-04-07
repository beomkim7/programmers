using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
            string answer = "";
            bool[] check = new bool[my_string.Length];
            for (int i = 0; i < indices.Length; i++)
                check[indices[i]] = true;

            for (int i = 0; i < check.Length; i++)
                if (!check[i]) answer += my_string[i];

            return answer;
    }
}