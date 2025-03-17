using System;
using System.Linq;
public class Solution {
    public int solution(string my_string) {
            int answer = 0;
            

            foreach(char c in my_string.ToCharArray())
                if (!int.TryParse(c.ToString(), out int result)) my_string=my_string.Replace(c, ' ');

            answer = my_string.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Sum(x => int.Parse(x));
            
            return answer;
    }
}