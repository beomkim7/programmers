using System;
using System.Linq;
public class Solution {
    public string solution(int[] food) {
            string answer = "";
            string first = "";
            for(int i = 1; i < food.Length; i++)
                for (int j = 0; j < food[i]/2; j++)
                    first += i.ToString();

            answer += first + "0" + new string(first.Reverse().ToArray());                        

            return answer;
    }
}