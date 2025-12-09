using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
int answer = 0;

            List<int> inter = reserve.Intersect(lost).ToList();

            List<int> lostLst = lost.Except(inter).OrderBy(x => x).ToList();
            List<int> reserveLst = reserve.Except(inter).OrderBy(x=>x).ToList();
                        

            for (int i = 0; i < reserveLst.Count; i++)
            {
                int before = reserveLst[i] - 1;
                int after = reserveLst[i] + 1;

                if (lostLst.Contains(before)) { lostLst.Remove(before); continue; }
                else if (lostLst.Contains(after)) { lostLst.Remove(after); }

            }
            answer = n - lostLst.Count();

            return answer;
    }
}