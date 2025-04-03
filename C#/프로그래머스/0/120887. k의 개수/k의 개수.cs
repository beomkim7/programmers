using System;
using System.Linq;
public class Solution {
    public int solution(int i, int j, int k) {
            int answer = 0;
            for (int check = i; check <= j; check++)
                if (check.ToString().Contains(k.ToString())) answer += check.ToString().Count(x => x.ToString() == k.ToString());
            return answer;
    }
}