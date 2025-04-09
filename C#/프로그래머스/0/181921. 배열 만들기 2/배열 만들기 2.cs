using System;
using System.Collections.Generic;
public class Solution {
        public long[] solution(int l, int r)
        {
            List<long> answer = new List<long>();
            string num = "";
            int length = (int)Math.Pow(2, r.ToString().Length)-1;

            for(int i = 1; i <=length; i ++)
            {
                int temp = i;
                num = "";
                while (temp > 0)
                {
                    num = num.Insert(0, (temp % 2).ToString());
                    temp = temp / 2;
                }
                long check = (int)(5 * long.Parse(num));
                if (check >= l && check <= r) answer.Add(check);
            }
            if (answer.Count == 0) answer.Add(-1);
            return answer.ToArray();
        }
}