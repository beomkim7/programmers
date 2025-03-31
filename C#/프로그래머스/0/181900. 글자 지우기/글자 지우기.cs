using System;
using System.Linq;
public class Solution {
    public string solution(string my_string, int[] indices) {
            string answer = string.Concat(my_string.Where((x,index)=>!indices.Contains(index)));
            return answer;
    }
}