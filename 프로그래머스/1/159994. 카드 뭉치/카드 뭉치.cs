using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
            string answer = "Yes";
            

            int one = 0;
            int two = 0;

            foreach(string s in goal)
            {
                if(cards1.Length > one && cards1[one] == s ) one++;
                
                
                else if(cards2.Length > two && cards2[two] == s) two++;
                
                else 
                {
                    answer = "No";
                    break;
                }
            }
            
            return answer;
    }
}