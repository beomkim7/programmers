using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] oneArr = new int[] { 1, 2, 3, 4, 5 };
            int[] twoArr = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] thrArr = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

                int one =0;
                int two =0;
                int thr = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (oneArr[i % oneArr.Length] == answers[i]) one++;

                if (twoArr[i % twoArr.Length] == answers[i]) two++;
                
                if (thrArr[i % thrArr.Length] == answers[i]) thr++;
                
            }
            dict[0] = one;
            dict[1] = two;
            dict[2] = thr;

            int maxV = dict.Values.Max();
            

            int[] answer = dict.Where(x=>x.Value==maxV).Select(x=>x.Key+1).ToArray();

            return answer;
    }
}