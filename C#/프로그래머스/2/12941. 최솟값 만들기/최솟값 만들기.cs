using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] A, int[] B) {
            int answer = 0;
            List<int> ALst = A.ToList();
            List<int> BLst = B.ToList();

            ALst=ALst.OrderBy(x => x).ToList();
            BLst =BLst.OrderByDescending(x => x).ToList();
            for (int i = 0; i < ALst.Count; i++)
                answer += ALst[i] * BLst[i];

            return answer;
    }
}