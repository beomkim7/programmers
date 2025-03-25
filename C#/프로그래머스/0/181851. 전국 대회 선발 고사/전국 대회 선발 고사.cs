using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] rank, bool[] attendance) {
            int answer = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < rank.Length; i++)
                if (attendance[i]) dict.Add(rank[i], i);

            var sorted = dict.OrderBy(x => x.Key).Select(x=>x.Value).ToArray();

            answer = sorted[0] * 10000 + sorted[1] * 100 + sorted[2];          

            return answer;
    }
}