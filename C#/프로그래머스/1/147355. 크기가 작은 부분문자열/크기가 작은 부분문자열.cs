using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution {
    public int solution(string t, string p) {
                        int answer = 0;
            int start = p.Length;
            int end = t.Length - start +1;

            List<long> nArr = new List<long>();
            
            for(int i = 0; i < end; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = i; j < i + start; j++)
                {
                    sb.Append(t[j]);
                }
                nArr.Add(long.Parse(sb.ToString()));
                Console.WriteLine(sb.ToString());
            }
            
            long check = long.Parse(p);
            foreach(long i in nArr)
            {
                
                if (i <= check) answer++;
            }
            

            return answer;
    }
}