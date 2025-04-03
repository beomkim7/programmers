using System;
using System.Linq;
public class Solution {
    public string solution(string my_string, int s, int e) {
            string answer = my_string.Remove(s,e-s+1).Insert(s,new string(my_string.Substring(s,e-s+1).Reverse().ToArray()));
            return answer;
    }
}