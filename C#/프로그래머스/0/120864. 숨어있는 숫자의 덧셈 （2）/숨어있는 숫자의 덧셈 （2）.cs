using System;
using System.Linq;
public class Solution {
    public int solution(string my_string) {
            foreach(char a in my_string)
            {
                if (!int.TryParse(a.ToString(), out int result)) my_string = my_string.Replace(a, ' ');
            }

            int answer = my_string.Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries)
                            .Sum(x=>int.Parse(x));
            Console.WriteLine(my_string);


            return answer;
    }
}