using System;using System.Linq;

public class Solution {
    public string solution(string my_string, int[,] queries) {
            string answer = "";
            
            for(int i = 0; i < queries.GetLength(0); i++)
            {
                int st = queries[i, 0];
                int ed = queries[i, 1] - st + 1;

                string change = new string(my_string.Substring(st, ed).Reverse().ToArray());
                my_string = my_string.Remove(st, ed)
                                    .Insert(st,change);
            }
            return my_string;
    }
}