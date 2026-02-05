using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
int answer = 0;
            List<int> inter = reserve.Intersect(lost).ToList();

            List<int> lostLst = lost.Except(inter).OrderBy(x => x).ToList();
            List<int> reserveLst = reserve.Except(inter).OrderBy(x => x).ToList();

            for (int i = 0; i < reserveLst.Count; i++)
            {
                int next = reserveLst[i] + 1;
                int prev = reserveLst[i] - 1;

                if (lostLst.Contains(prev)) { lostLst.Remove(prev); continue; }
                else if (lostLst.Contains(next)) lostLst.Remove(next);
            }

            answer = n - lostLst.Count();
            return answer;
    }
}