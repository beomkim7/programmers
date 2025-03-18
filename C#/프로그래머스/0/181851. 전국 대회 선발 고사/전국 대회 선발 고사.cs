using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
int answer = 0;
            var lst = new List<(int rank, int index)>();

            for(int i = 0; i < rank.Length; i++)
            {
                if (!attendance[i]) continue;
                lst.Add((rank[i], i));
            }

            var ansList = lst.OrderBy(x => x.rank).Select(x => x.index).Take(3).ToArray();
            answer = 10000 * ansList[0] + 100 * ansList[1] + ansList[2];

            return answer;
    }
}