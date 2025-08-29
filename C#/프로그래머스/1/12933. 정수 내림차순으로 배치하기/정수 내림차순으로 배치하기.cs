using System;
using System.Linq;
public class Solution {
    public long solution(long n) {
            long answer = 0;
            
            string st = n.ToString();
            st = new string(st.AsEnumerable().OrderByDescending(x => x).ToArray());
            answer = long.Parse(st);

            return answer;
    }
}